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
            //Application.Run(new Welcome());
            Application.Run(new GUI.frmDashboard());

=======
            Application.Run(new Welcome());
>>>>>>> c19a0902fb66773a1cf003325c2c3c5437fc834f
        }
    }
}