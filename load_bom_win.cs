using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssembleAssist
{
    public partial class load_bom_win : Form
    {
        private int bom_starting_line = 1;  //specifies the line number (1 to n) of the first valid bom data line
        private List<string> bom_content = new List<string>();  //lists all lines, readed from the bom csv file
        private DataTable dt = new DataTable(); //hold the data table, displayed by the BoM Preview DataViewer
        private char bom_seperator = ';';   //holds the currently selected CSV column seperator cahr
        private int designator_column;      //holds the index of the designator column of the BoM
        private int param1_column;          //holds the index of the first BoM column, displayed to the user during baord assembly
        private int param2_column;          //holds the index of the second BoM column, displayed to the user during baord assembly
        private int state = 0;              //prevents user from applying changes until designator, param1 and param2 columns are specified

        private string help_text =  "1. Set number of the first valid data row in BoM.\n" +
                                    "2. Select seperator to preview the BoM correctly.\n" +
                                    "3. Select a cell in the column that holds the designators and click \"select designator column.\"\n" +
                                    "4. Select first and second BoM parameter to show during assembly process by selecting a cell and clicking particular button.\n" +
                                    "5. Click \"Ok\" button to finish. Appearing message shows count of loaded BoM lines.";

        data shared_data_ext = null;

        /*
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
        */

        public load_bom_win(data shared_data_)
        {
            shared_data_ext = shared_data_;
            InitializeComponent();
        }

        private void load_bom_win_Load(object sender, EventArgs e)
        {
            if (shared_data_ext.bom_path == "")
            {
                MessageBox.Show("Filepath is empty");
                this.Close();
                return;
            }

            try
            {
                var tmp = File.ReadLines(shared_data_ext.bom_path);
                foreach (string l in tmp)
                {
                    bom_content.Add(l);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            if (bom_content.Count < 1)
            {
                MessageBox.Show("BoM is empty.");
                this.Close();
            }

            bom_starting_line = 1;
            text_startline.Text = bom_starting_line.ToString();
            bom_seperator = ';';
            updateBoMPreview();

        }

        private void radio_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                bom_seperator = '.';
                updateBoMPreview();
            }
        }

        private void radio_comma_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                bom_seperator = ',';
                updateBoMPreview();
            }
        }

        private void radio_semicolon_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                bom_seperator = ';';
                updateBoMPreview();
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
                bom_seperator = text_custom.Text[0];
                updateBoMPreview();
            }
        }

        private void updateBoMPreview()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            try
            {
                bom_starting_line = Convert.ToInt32(text_startline.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value for starting line.");
                return;
            }


            if ((bom_starting_line < 1) || (bom_starting_line > bom_content.Count))
            {
                MessageBox.Show("invalid value for starting line. Choose 1 to number of lines of BoM. BoM has " + bom_content.Count.ToString() + " lines.");
                return;
            }

            dt.Clear();
            int col_count = bom_content[bom_starting_line-1].Split(bom_seperator).Length;
            //spawn necessary number of columns 
            for(int i=0; i< col_count; i++)
            {
                dt.Columns.Add("", typeof(string));
            }



            //add rows
            for(int row_cnt= bom_starting_line-1; row_cnt < bom_starting_line+9; row_cnt++)
            {
                string[] current_row = new string[col_count];
                string[] row_to_add = new string[col_count];

                current_row = bom_content[row_cnt].Split(bom_seperator);

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

            BoM_Previewer.DataSource = dt;

            
            // disable sorting for all columns 
            foreach (DataGridViewColumn c in BoM_Previewer.Columns)
            {
               c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
        }

        private void text_startline_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bom_starting_line = Convert.ToInt32(text_startline.Text) -1 ; // 0 to n
            }
            catch
            {
                return;
            }

            updateBoMPreview();
        }


        private void ok_butt_Click(object sender, EventArgs e)
        {
            shared_data_ext.bom_list.Clear();

            for (int i = bom_starting_line-1; i < bom_content.Count; i++)  // for every line in BoM, starting with the defined starting line..
            {
                string[] bom_cells = bom_content[i].Split(bom_seperator);   // split line by defined seperator

                int min_cell_cnt_required = Math.Max(designator_column, Math.Max(param1_column, param2_column));    // calculate which index to select from row cells is the greatest.
                if (bom_cells.Length < min_cell_cnt_required + 1) // in case this csv row has too less cells (is currupted), message, clear bom list (e.g. for new atempt) and return to main window.
                {
                    MessageBox.Show("Too few elements in csv row " + i.ToString());
                    shared_data_ext.bom_list.Clear();
                    return;
                }

                string[] designators = bom_cells[designator_column].Split(',');
                for(int j=0; j<designators.Length; j++)
                {
                    designators[j] = designators[j].Replace(" ", "");
                }

                shared_data_ext.bom_list.Add(new bom_entry());                                          // spawn and add new instance of bom_entry-class to list
                shared_data_ext.bom_list.Last().designators.AddRange(designators);  // fill up new instance
                shared_data_ext.bom_list.Last().parameter1  = bom_cells[param1_column];
                shared_data_ext.bom_list.Last().parameter2  = bom_cells[param2_column];
            }

            MessageBox.Show("Loaded " + shared_data_ext.bom_list.Count.ToString() + " lines from BoM list.");

            this.Close();
        }

        private void butt_select_designator_Click(object sender, EventArgs e)
        {
            if (BoM_Previewer.SelectedCells.Count < 1)
            {
                MessageBox.Show("Select one cell");
                return;
            }
            else if (BoM_Previewer.SelectedCells.Count > 1)
            {
                MessageBox.Show("Select only one cell");
                return;
            }
            else
            {
                designator_column = BoM_Previewer.SelectedCells[0].ColumnIndex;
                label_selected_designator.Text = designator_column.ToString();
                state |= 4;
            }

            if (state == 7)
            {
                ok_butt.Enabled = true;
            }

            BoM_Previewer.ClearSelection();
        }

        private void butt_param1_Click(object sender, EventArgs e)
        {
            if (BoM_Previewer.SelectedCells.Count < 1)
            {
                MessageBox.Show("Select one cell");
                return;
            }
            else if (BoM_Previewer.SelectedCells.Count > 1)
            {
                MessageBox.Show("Select only one cell");
                return;
            }
            else
            {
                param1_column = BoM_Previewer.SelectedCells[0].ColumnIndex;
                label_param1.Text = param1_column.ToString();
                state |= 2;
            }

            if (state == 7)
            {
                ok_butt.Enabled = true;
            }

            BoM_Previewer.ClearSelection();
        }

        private void butt_param2_Click(object sender, EventArgs e)
        {
            if (BoM_Previewer.SelectedCells.Count < 1)
            {
                MessageBox.Show("Select one cell");
                return;
            }
            else if (BoM_Previewer.SelectedCells.Count > 1)
            {
                MessageBox.Show("Select only one cell");
                return;
            }
            else
            {
                param2_column = BoM_Previewer.SelectedCells[0].ColumnIndex;
                label_param2.Text = param2_column.ToString();
                state |= 1;
            }

            if (state == 7)
            {
                ok_butt.Enabled = true;
            }

            BoM_Previewer.ClearSelection();
        }

        private void text_custom_TextChanged(object sender, EventArgs e)
        {
            if (radio_custom.Checked == true)
            {
                bom_seperator = text_custom.Text[0];
                updateBoMPreview();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info_box info = new Info_box(help_text);
            info.ShowDialog();
        }
    }
}
