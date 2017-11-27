using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.ControlBox = false;
            timer.Start();
        }

        private void btnForceExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            new Login().Show();
            this.Hide();
        }
    }
}
