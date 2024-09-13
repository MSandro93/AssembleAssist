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
    public partial class Info_box : Form
    {
        private string content;

        public Info_box(string content_)
        {
            content = content_;
            InitializeComponent();
        }

        private void Info_box_Load(object sender, EventArgs e)
        {
            text_HowTo.Text = content;
        }
    }
}
