using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NucZip
{
    static class Program
    {
        static Panel panel = null;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            panel = new Panel();
            Application.Run(panel);
        }
        /// <summary>
        /// Gets the instance for the cracking thread
        /// </summary>
        /// <returns></returns>
        public static Panel getInstance()
        {
            return panel;
        }
    }
}
