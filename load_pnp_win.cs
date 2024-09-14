using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace AssembleAssist
{
    public partial class load_pnp_win : Form
    {
        private data shared_data_ext = null;
        private List<string> pnp_lines = new List<string>();
        private int pnp_starting_line = 1;
        private char pnp_seperator = ';';
        private DataTable dt = new DataTable();
        private int state = 0;
        private int designatort_column = 0;
        private int x_cootdiante_column = 0;
        private int y_cootdiante_column = 0;
        private int layer_colum = 0;
        public string top_layer_name = "";
        public string bot_layer_name = "";
        public char local_system_decimal_seperator = ',';

        private string help_string = "1. Set number of the first valid data row in pick and place table\n" +
                                    "2. Select seperator until preview of BoM is displayed correctly.\n" +
                                    "3. Select a cell in the column that holds the designators and click \"select designator column\"\n" +
                                    "4. Select x and y coorinate column by selecting a cell and clicking particular button\"\n" +
                                    "5. Select a cell in the column that holds the board side and click \"select layer\". Specify the stings for top and bottom side in the appearing dialog.\n    Coordinates have to be absolute";


        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public load_pnp_win(data shared_data_)
        {
            shared_data_ext = shared_data_;
            local_system_decimal_seperator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            InitializeComponent();
        }

        private void load_pnp_win_Load(object sender, EventArgs e)
        {
            if (shared_data_ext.pnp_path == "")
            {
                MessageBox.Show("Filepath is empty");
                this.Close();
                return;
            }

            try
            {
                var tmp = File.ReadLines(shared_data_ext.pnp_path);
                foreach (string l in tmp)
                {
                    pnp_lines.Add(l);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                return;
            }

            

            if (pnp_lines.Count < 1)
            {
                MessageBox.Show("Pick and Place list is empty.");
                this.Close();
            }

            pnp_starting_line = 1;
            text_startline.Text = pnp_starting_line.ToString();
            pnp_seperator = ';';
            updatePnPPreview();
        }

        private void radio_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                pnp_seperator = '.';
                updatePnPPreview();
            }
        }

        private void radio_comma_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                pnp_seperator = ',';
                updatePnPPreview();
            }
        }

        private void radio_semicolon_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                pnp_seperator = ';';
                updatePnPPreview();
            }
        }

        private void radio_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (text_custom.Text.Length < 1)
            {
                return;
            }

            if (((RadioButton)sender).Checked == true)
            {
                pnp_seperator = text_custom.Text[0];
                updatePnPPreview();
            }
        }

        private void text_startline_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pnp_starting_line = Convert.ToInt32(text_startline.Text);
            }
            catch
            {
                return;
            }

            updatePnPPreview();
        }

        private void text_custom_TextChanged(object sender, EventArgs e)
        {
            if (radio_custom.Checked == true)
            {
                pnp_seperator = text_custom.Text[0];
                updatePnPPreview();
            }
        }

        private void updatePnPPreview()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            try
            {
                pnp_starting_line = Convert.ToInt32(text_startline.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value for starting line.");
                return;
            }


            if ((pnp_starting_line < 1) || (pnp_starting_line > pnp_lines.Count))
            {
                MessageBox.Show("invalid value for starting line. Choose 1 to number of lines of BoM. BoM has " + pnp_lines.Count.ToString() + " lines.");
                return;
            }

            dt.Clear();
            int col_count = pnp_lines[pnp_starting_line - 1].Split(pnp_seperator).Length;
            //spawn necessary number of columns 
            for (int i = 0; i < col_count; i++)
            {
                dt.Columns.Add("", typeof(string));
            }



            //add rows
            for (int row_cnt = pnp_starting_line - 1; row_cnt < pnp_starting_line + 9; row_cnt++)
            {
                string[] current_row = new string[col_count];
                string[] row_to_add = new string[col_count];

                current_row = pnp_lines[row_cnt].Split(pnp_seperator);

                if (current_row.Length > col_count) //if current row has to many cells after the split, short it
                {
                    Array.Copy(current_row, row_to_add, col_count);
                }
                else // if it is too short, fill it by blanks
                {
                    Array.Copy(current_row, row_to_add, current_row.Length);
                }


                dt.Rows.Add(row_to_add);
            }

            PnP_Previewer.DataSource = dt;


            // disable sorting for all columns 
            foreach (DataGridViewColumn c in PnP_Previewer.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void butt_x_coor_Click(object sender, EventArgs e)
        {
            if (PnP_Previewer.SelectedCells.Count < 1)
            {
                MessageBox.Show("Select one cell");
                return;
            }
            else if (PnP_Previewer.SelectedCells.Count > 1)
            {
                MessageBox.Show("Select only one cell");
                return;
            }
            else
            {
                x_cootdiante_column = PnP_Previewer.SelectedCells[0].ColumnIndex;
                label_x_coor.Text = x_cootdiante_column.ToString();
                state |= 2;
            }

            if (state == 15)
            {
                ok_butt.Enabled = true;
            }

            PnP_Previewer.ClearSelection();
        }

        private void butt_select_designator_Click(object sender, EventArgs e)
        {
            if (PnP_Previewer.SelectedCells.Count < 1)
            {
                MessageBox.Show("Select one cell");
                return;
            }
            else if (PnP_Previewer.SelectedCells.Count > 1)
            {
                MessageBox.Show("Select only one cell");
                return;
            }
            else
            {
                designatort_column = PnP_Previewer.SelectedCells[0].ColumnIndex;
                label_selected_designator.Text = designatort_column.ToString();
                state |= 4;
            }

            if (state == 15)
            {
                ok_butt.Enabled = true;
            }

            PnP_Previewer.ClearSelection();
        }

        private void butt_y_coor_Click(object sender, EventArgs e)
        {
            if (PnP_Previewer.SelectedCells.Count < 1)
            {
                MessageBox.Show("Select one cell");
                return;
            }
            else if (PnP_Previewer.SelectedCells.Count > 1)
            {
                MessageBox.Show("Select only one cell");
                return;
            }
            else
            {
                y_cootdiante_column = PnP_Previewer.SelectedCells[0].ColumnIndex;
                label_y_coor.Text = y_cootdiante_column.ToString();
                state |= 1;
            }

            if (state == 15)
            {
                ok_butt.Enabled = true;
            }

            PnP_Previewer.ClearSelection();
        }


        private double corrToDouble(string coor)
        {
            coor = coor.Replace("\"", "");
            coor = coor.Replace('.', local_system_decimal_seperator);
            coor = coor.Replace(',', local_system_decimal_seperator);

            return Convert.ToDouble(coor);
        }


        private void ok_butt_Click(object sender, EventArgs e)
        {
            for (int row_cnt = pnp_starting_line - 1; row_cnt < pnp_lines.Count; row_cnt++)
            {
                string[] current_row = pnp_lines[row_cnt].Split(pnp_seperator);

                string current_Layer_name = current_row[layer_colum].Replace("\"", "");
                if (current_Layer_name != comboBox_selected_layer.SelectedItem.ToString()) // if component is not on the board side to assemble, skip it..
                {
                    continue;
                }

                int min_cell_cnt_required = Math.Max(designatort_column, Math.Max(x_cootdiante_column, y_cootdiante_column));
                if (current_row.Length < min_cell_cnt_required+1) // in case this csv row has too less cells (is currupted), break
                {
                    MessageBox.Show("Too few elements in csv row " + row_cnt.ToString());
                    shared_data_ext.pnp_list.Clear();
                    return;
                }

                shared_data_ext.pnp_list.Add(new pnp_entry( current_row[designatort_column].ToString().Replace("\"", ""),
                                                            corrToDouble(current_row[x_cootdiante_column]),
                                                            corrToDouble(current_row[y_cootdiante_column])) );

            }

            MessageBox.Show("Loaded " + shared_data_ext.pnp_list.Count.ToString() + " lines from pick and place list.");

            this.Close();
        }

        private void but_select_layer_Click(object sender, EventArgs e)
        {
            if (PnP_Previewer.SelectedCells.Count < 1)
            {
                MessageBox.Show("Select one cell");
                return;
            }
            else if (PnP_Previewer.SelectedCells.Count > 1)
            {
                MessageBox.Show("Select only one cell");
                return;
            }
            else
            {
                layer_colum = PnP_Previewer.SelectedCells[0].ColumnIndex;
                label_layer.Text = layer_colum.ToString();
                state |= 8;
            }

            layer_diag layer_diag_inst = new layer_diag(this);
            layer_diag_inst.ShowDialog();

            comboBox_selected_layer.Items.Add(top_layer_name);
            comboBox_selected_layer.Items.Add(bot_layer_name);
            comboBox_selected_layer.SelectedIndex = 0;

            if (state == 15)
            {
                ok_butt.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info_box info = new Info_box(help_string);
            info.ShowDialog();
        }
    }
}
