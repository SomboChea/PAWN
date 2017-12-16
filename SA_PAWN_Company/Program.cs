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

<<<<<<< HEAD
            Application.Run(new Login());
=======
            Application.Run(new frmDashboard());
>>>>>>> bc69fe7376d26b3d0a9e315bdcdd74952fd3e4cc
        }
    }
}