using SA_PAWN_Company.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.Run(new Welcome());
=======
            Application.Run(new frmDashboardMaterial());
>>>>>>> 85e2dff91365a86b669e0a7e166b8472a528f95e
        }
    }
}