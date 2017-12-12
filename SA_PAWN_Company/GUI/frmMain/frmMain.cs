using Helpers;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            FullMode.Fullscreen(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool open = true;

        private void btnNav_Click(object sender, EventArgs e)
        {
            panNav.Visible = false;
            panNav.Width = open ? 0 : 258;
            open = !open;
            bunifuTransition1.ShowSync(panNav, true, null);
        }
    }
}