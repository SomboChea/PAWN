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
    public partial class frmDashboardMaterial : Form
    {
        public frmDashboardMaterial()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            new Loading(this,new Login()).ShowDialog();
        }

       

        bool open = true;
        private void btnNav_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = false;
            bunifuGradientPanel2.Width = open?43: 242;
            bunifuGradientPanel2.GradientTopLeft = Color.White;
            bunifuGradientPanel2.GradientTopRight = Color.White;
            profileImg.Visible = !open;
            open = !open;
            bunifuTransition1.ShowSync(bunifuGradientPanel2,true,null);
        }
    }
}
