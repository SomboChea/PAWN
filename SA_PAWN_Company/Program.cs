using System;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Welcome());
            Application.Run(new GUI.frmDashboard());

        }
    }
}