using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A18_Ex02_Lior_Yuval
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
