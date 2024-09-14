using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssembleAssist.pnp_entry;

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
        public enum component_state
        {
            not_placed = 0,
            placed = 1,
            skipped = 2,
            _error_ = 99
        }

        public string desigantor;
        public double x;
        public double y;
        public component_state place_state;

        public pnp_entry()
        {
            place_state = component_state.not_placed;
        }

        public pnp_entry(string desc_, double x_ , double y_)
        {
            desigantor = desc_.Replace("\"", "");
            x = x_;
            y = y_;
            place_state = component_state.not_placed;
        }
    }

    public class data
    {
        public List<bom_entry> bom_list = new List<bom_entry> ();
        public List<pnp_entry> pnp_list = new List<pnp_entry>();
        public string bom_path;
        public string pnp_path;

        public component_state getStateByDesignator(string desc_)
        {
            foreach (pnp_entry l in pnp_list)
            {
                if (l.desigantor == desc_)
                {
                    return l.place_state;
                }
            }
            return component_state._error_;
        }

        public int setStateByDesignator(string desc_, component_state state_)
        {
            for(int i = 0; i < pnp_list.Count; i++)
            {
                if (pnp_list[i].desigantor == desc_)
                {
                    pnp_list[i].place_state = state_;
                    return 0;
                }
            }
            return 1;
        }
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
