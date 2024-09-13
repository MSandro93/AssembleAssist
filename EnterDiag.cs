using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssembleAssist
{
    public partial class EnterDiag : Form
    {
        main_win parent;

        public EnterDiag(main_win parent_, string promt)
        {
            InitializeComponent();
            label1.Text = promt;

            parent = parent_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sep_ = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            string rep = textBox1.Text.Replace('.', CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]);
            rep = rep.Replace(',', CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]);

            try
            {
                Convert.ToDouble(rep);
            }
            catch
            {
                MessageBox.Show("Invalid value. Enter float");
                return;
            }

            parent.reportToParent(rep);
            this.Close();
        }

        private void EnterDiag_Load(object sender, EventArgs e)
        {
            label1.Size = new System.Drawing.Size(230, 36);
            label1.AutoSize = false;
        }
    }
}
