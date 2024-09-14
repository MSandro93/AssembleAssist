using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;
using static AssembleAssist.pnp_entry;

namespace AssembleAssist
{
    public partial class main_win : Form
    {
        public data shared_data;
        public Image asd_image;
        public double resolution_x = 1.0; //pixel per unit
        public double resolution_y = 1.0; //pixel per unit
        public int oringin_x = 0;   //x component of board origin in pixels
        public int oringin_y = 0;   //y component of board origin in pixels
        string current_designator = "";
        int oringin_selecting_state = 0;
        int board_width_px = 0;
        int board_height_px = 0;
        int state = 0;
        int current_bom_line = 0;
        int current_comp_in_bom_line = 0;
        Pen pen = new Pen(Color.Red, 2.5f);


        public main_win()
        {
            InitializeComponent();
            shared_data = new data();
        }

        private void load_bom_butt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd_bom = new OpenFileDialog();
            fd_bom.Filter = "csv file (*.csv)|*.csv";
            fd_bom.ShowDialog();

            shared_data.bom_path = fd_bom.FileName;
            load_bom_win load_bom_win_inst = new load_bom_win(shared_data);
            load_bom_win_inst.ShowDialog();

            label_bom_lines_loaded.Text = shared_data.bom_list.Count.ToString();
            if (Convert.ToInt32(label_bom_lines_loaded.Text) > 0)
            {
                label_bom_lines_loaded.ForeColor = Color.DarkGreen;
                state |= 1;
            }
            else
            {
                label_bom_lines_loaded.ForeColor = Color.Red;
                state &= ~1;
            }
        }


        private void load_pnp_butt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd_pnp = new OpenFileDialog();
            fd_pnp.Filter = "csv file (*.csv)|*.csv";
            fd_pnp.ShowDialog();

            shared_data.pnp_path = fd_pnp.FileName;
            load_pnp_win load_pnp_win_inst = new load_pnp_win(shared_data);
            load_pnp_win_inst.ShowDialog();

            label_pnp_lines_loaded.Text = shared_data.pnp_list.Count.ToString();
            if (Convert.ToInt32(label_pnp_lines_loaded.Text) > 0)
            {
                label_pnp_lines_loaded.ForeColor = Color.DarkGreen;
                state |= 2;
            }
            else
            {
                label_pnp_lines_loaded.ForeColor = Color.Red;
                state &= ~2;
            }
        }

        private void load_asd_butt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd_asd = new OpenFileDialog();
            fd_asd.Filter = "images (*.png)|*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.bmp)|*.bmp";
            fd_asd.ShowDialog();

            asd_image = Image.FromFile(fd_asd.FileName);

            // draws resized asd-image to picturebox. Replaces original image with the resized one. Resized to fit the picturebox.
            double aspect_ratio_pb    = pictureBox_asd_image.Width / (pictureBox_asd_image.Height * 1.0);
            double aspect_ratio_image = asd_image.Width / (asd_image.Height * 1.0);

            int new_image_height = 0;
            int new_image_width = 0;

            if (aspect_ratio_image < aspect_ratio_pb) //image will be scaled to the full height of the picture box -> bars will stay empty at left and right border
            {
                new_image_height = pictureBox_asd_image.Height;
                new_image_width = Convert.ToInt32(Math.Round(pictureBox_asd_image.Height * aspect_ratio_image));
            }

            else if (aspect_ratio_image >= aspect_ratio_pb) //image will be scaled to the full width of the picture box -> bars will stay empty at top and bottom border
            {
                new_image_height = Convert.ToInt32(Math.Round(pictureBox_asd_image.Width / aspect_ratio_image));
                new_image_width = pictureBox_asd_image.Width;
            }

            Bitmap b = new Bitmap(pictureBox_asd_image.Width, pictureBox_asd_image.Height);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; g.DrawImage(asd_image, 0, 0, new_image_width, new_image_height);
            g.Dispose();
            asd_image.Dispose();
            asd_image = (Image)b.Clone();
            //

            pictureBox_asd_image.Image = asd_image;
            pictureBox_asd_image.Update();


        }

        private void butt_set_up_asd_origin_dimension_Click(object sender, EventArgs e)
        {

            butt_set_up_asd_origin_dimension.BackColor = Color.FromArgb(255, 128, 128); // chilled red
            state &= ~4;

            if (pictureBox_asd_image.Image == null)
            {
                MessageBox.Show("Load image first");
                oringin_selecting_state = 0;
                return;
            }

            pictureBox_asd_image.Image = (Image)asd_image.Clone();
            pictureBox_asd_image.Update();

            MessageBox.Show("Click on board origin");
            oringin_selecting_state = 1;    
        }

        private void pictureBox_asd_image_Click(object sender, MouseEventArgs e)
        {
            switch (oringin_selecting_state)
            {
                case 1:
                    {
                        oringin_x = e.Location.X;
                        oringin_y = e.Location.Y;
                        oringin_selecting_state = 2;
                        MessageBox.Show("Click board edge and specify maximum board width in appearing dialog.");
                        break;
                    }

                case 2:
                    {
                        EnterDiag enterMaxX_diag = new EnterDiag(this, "Enter maximum board width (you clicked on) in the unit that is used by the pick and place list as float.");
                        oringin_selecting_state = 3;
                        board_width_px = e.Location.X - oringin_x;
                        enterMaxX_diag.Show();
                        break;
                    }

                case 4:
                    {
                        EnterDiag enterMaxY_diag = new EnterDiag(this, "Enter maximum board height (you clicked on) in the unit that is used by the pick and place list as float.");
                        oringin_selecting_state = 6;
                        board_height_px = oringin_y  - e.Location.Y;
                        enterMaxY_diag.Show();
                        break;
                    }
            }
        }

        public void reportToParent(string report)
        {
            switch (oringin_selecting_state)
            {
                case 3:
                    {
                        resolution_x = board_width_px / Convert.ToDouble(report);
                        MessageBox.Show("Click board edge and specify maximum board height in appearing dialog.");
                        oringin_selecting_state = 4;
                        break;
                    }

                case 6:
                    {
                        resolution_y = board_height_px / Convert.ToDouble(report);
                        oringin_selecting_state = 7;
                        butt_set_up_asd_origin_dimension.BackColor = Color.FromArgb(128, 255, 128); // chilled green
                        state |= 4;
                        break;
                    }
            }
        }

        private void butt_start_assembly_Click(object sender, EventArgs e)
        {
            if (state != 7)
            {
                MessageBox.Show("Load BoM, pick and place data and assembly drawing. Specify dimentions of board by clicking \"setup\"-button.");
                return;
            }

            progressBar.Maximum = shared_data.pnp_list.Count;
            progressBar.Minimum = 0;
            progressBar.Value   = 0;
            label_progress.Text = "0/" + shared_data.pnp_list.Count().ToString() + "  (0%)";

            current_bom_line = 1;
            current_comp_in_bom_line = 1;
            update_assemble_overview();
        }

        private bool probeComponent(string decs_)
        {
            bool found = false;

            foreach (pnp_entry cmp in shared_data.pnp_list) // search for coordinates of current component in pick an place lost
            {
                Console.WriteLine(cmp.desigantor);

                if (cmp.desigantor == decs_)
                {
                    int x = Convert.ToInt32(Math.Round((cmp.x * resolution_x) + oringin_x));
                    int y = oringin_y - Convert.ToInt32(Math.Round(cmp.y * resolution_y));

                    pictureBox_asd_image.Image = (Image)asd_image.Clone();
                    Graphics g_ = Graphics.FromImage(pictureBox_asd_image.Image);

                    g_.DrawLine(pen, 0, y, pictureBox_asd_image.Image.Width, y);  //draw horizontal component of the cross
                    g_.DrawLine(pen, x, 0, x, pictureBox_asd_image.Image.Height);  //draw vertical component of the cross
                    pictureBox_asd_image.Update();
                    found = true;
                    break;
                }
            }

            return found;
        }

        private void update_assemble_overview()
        {
            current_designator = shared_data.bom_list[current_bom_line].designators[current_comp_in_bom_line - 1];

            label_bom_line.Text = current_bom_line.ToString() + "/" + shared_data.bom_list.Count.ToString();
            label_param1.Text = shared_data.bom_list[current_bom_line].parameter1;
            label_param2.Text = shared_data.bom_list[current_bom_line].parameter2;
            label_cnt_in_bom_line.Text = current_comp_in_bom_line.ToString() + "/" + shared_data.bom_list[current_bom_line].designators.Count().ToString();
            label_current_component.Text = current_designator;

            component_state placedState= shared_data.getStateByDesignator(current_designator);
            switch (placedState)
            {
                case component_state.not_placed:
                {
                    label_component_status.Text = "not placed";
                    label_component_status.ForeColor = Color.Black;
                    break;
                }
                case component_state.placed:
                {
                    label_component_status.Text = "placed";
                    label_component_status.ForeColor = Color.Green;
                    break;
                }
                case component_state.skipped:
                {
                    label_component_status.Text = "skipped";
                    label_component_status.ForeColor = Color.Orange;
                    break;
                }
            }

            probeComponent(current_designator);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                current_comp_in_bom_line -= 1;
                if (current_comp_in_bom_line < 1)
                {
                    current_comp_in_bom_line = 1;
                }

                if ((current_comp_in_bom_line == 1) && (current_bom_line > 1))
                {
                    butt_previous_bom_line.Enabled = true;
                }
                else
                {
                    butt_previous_bom_line.Enabled = false;
                }

                if (current_comp_in_bom_line < shared_data.bom_list[current_bom_line].designators.Count())
                {
                    butt_next_bom_line.Enabled = false;
                }
                else
                {
                    butt_next_bom_line.Enabled = true;
                }

                update_assemble_overview();
                return true;
            }

            else if (keyData == Keys.Right)
            {
                current_comp_in_bom_line += 1;
                if (current_comp_in_bom_line > shared_data.bom_list[current_bom_line].designators.Count())
                {
                    current_comp_in_bom_line = shared_data.bom_list[current_bom_line].designators.Count();
                }

                if (current_comp_in_bom_line == shared_data.bom_list[current_bom_line].designators.Count())
                {
                    butt_next_bom_line.Enabled = true;
                }
                else
                {
                    butt_next_bom_line.Enabled = false;
                }

                if ((current_comp_in_bom_line == 1) && (shared_data.bom_list[current_bom_line].designators.Count() == 1))
                {
                    butt_previous_bom_line.Enabled = true;
                }
                else
                {
                    butt_previous_bom_line.Enabled = false;
                }

                update_assemble_overview();
                return true;
            }

            else if (keyData == Keys.Space)
            {
                switch (shared_data.getStateByDesignator(current_designator))
                {
                    case pnp_entry.component_state.not_placed:
                    case pnp_entry.component_state.skipped:
                        {
                            shared_data.setStateByDesignator(current_designator, component_state.placed);
                            label_component_status.Text = "placed";
                            label_component_status.ForeColor = Color.Green;
                            break;
                        }
                    case pnp_entry.component_state.placed:
                        {
                            shared_data.setStateByDesignator(current_designator, component_state.not_placed);
                            label_component_status.Text = "not placed";
                            label_component_status.ForeColor = Color.Black;
                            break;
                        }
                }

                int cnt_placed = shared_data.howManyPlacedSkipped();
                int percentage = Convert.ToInt32(Math.Round((cnt_placed / (shared_data.pnp_list.Count() * 1.0)) * 100));
                label_progress.Text = cnt_placed.ToString() + "/" + shared_data.pnp_list.Count().ToString() + "  (" + percentage.ToString() + "%)";
                progressBar.Value = cnt_placed;

                return true;
            }

            else if (keyData == Keys.Escape)
            {
                switch (shared_data.getStateByDesignator(current_designator))
                {
                    case pnp_entry.component_state.not_placed:
                    case pnp_entry.component_state.placed:
                        {
                            shared_data.setStateByDesignator(current_designator, component_state.skipped);
                            label_component_status.Text = "skipped";
                            label_component_status.ForeColor = Color.Orange;
                            break;
                        }
                    case pnp_entry.component_state.skipped:
                        {
                            shared_data.setStateByDesignator(current_designator, component_state.not_placed);
                            label_component_status.Text = "not placed";
                            label_component_status.ForeColor = Color.Black;
                            break;
                        }
                }

                int cnt_placed = shared_data.howManyPlacedSkipped();
                int percentage = Convert.ToInt32(Math.Round((cnt_placed / (shared_data.pnp_list.Count() * 1.0)) * 100));
                label_progress.Text = cnt_placed.ToString() + "/" + shared_data.pnp_list.Count().ToString() + "  (" + percentage.ToString() + "%)";
                progressBar.Value = cnt_placed;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void butt_next_bom_line_Click(object sender, EventArgs e)
        {
            current_bom_line++;
            current_comp_in_bom_line = 1;

            if (shared_data.bom_list[current_bom_line].designators.Length > 1)
            {
                butt_next_bom_line.Enabled = false;
            }

            butt_previous_bom_line.Enabled=true;

            update_assemble_overview();
        }

        private void butt_previous_bom_line_Click(object sender, EventArgs e)
        {
            current_bom_line--;
            current_comp_in_bom_line = shared_data.bom_list[current_bom_line].designators.Length;

            if (shared_data.bom_list[current_bom_line].designators.Length > 1)
            {
                butt_previous_bom_line.Enabled = false;
            }

            butt_next_bom_line.Enabled = true;

            update_assemble_overview();
        }

        private void butt_probe_MouseDown(object sender, MouseEventArgs e)
        {
            if (!probeComponent(text_probe.Text))
            {
                MessageBox.Show("Could not find " + text_probe.Text);
            }
        }

        private void butt_probe_MouseUp(object sender, MouseEventArgs e)
        {
            probeComponent(current_designator);
        }
    }
}
