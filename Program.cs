using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssembleAssist
{
    public class bom_entry
    {
        //public List <string> designators = new List <string> ();
        public string[] designators;
        public string parameter1;
        public string parameter2;
        public int count;

        public bom_entry()
        { }
    }

    public class pnp_entry
    {
        public string desigantor;
        public double x;
        public double y;

        public pnp_entry()
        { }

        public pnp_entry(string desc_, double x_ , double y_)
        {
            desigantor = desc_.Replace("\"", "");
            x = x_;
            y = y_;
        }
    }

    public class data
    {
        public List<bom_entry> bom_list = new List<bom_entry> ();
        public List<pnp_entry> pnp_list = new List<pnp_entry>();
        public string bom_path;
        public string pnp_path;
    }

    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_win());
        }
    }
}
