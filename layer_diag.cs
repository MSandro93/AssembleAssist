using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssembleAssist
{
    public partial class layer_diag : Form
    {
        private load_pnp_win parent_win;

        public layer_diag(load_pnp_win win_)
        {
            parent_win = win_;
            InitializeComponent();
        }

        private void butt_ok_Click(object sender, EventArgs e)
        {
            if ((text_top_layer.Text.Length < 0) || (text_bot_layer.Text.Length < 0))
            {
                MessageBox.Show("specifier empty");
                return;
            }

            parent_win.top_layer_name = text_top_layer.Text;
            parent_win.bot_layer_name = text_bot_layer.Text;

            this.Close();
        }
    }
}
