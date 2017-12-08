using SA_PAWN_Company.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class Loading : Form
    {
        private Form oContext, nContext;
        private bool hasContext = false;
        private Overlay lay = new Overlay();

        public Loading()
        {
            lay.Show();
            InitializeComponent();
            ControlBox = false;
            timerLoading.Start();
            TopMost = true;
            TopLevel = true;
            hasContext = false;
        }

        public Loading(Form oldContext, Form newContext, int interval = 2000)
        {
            InitializeComponent();
            ControlBox = false;
            timerLoading.Interval = interval;
            timerLoading.Start();

            oContext = oldContext;
            nContext = newContext;

            TopMost = true;
            TopLevel = true;
            hasContext = true;

            showOverlay();
            hideNewContext();
        }

        private void showOverlay()
        {
            lay.Show();
            lay.TopMost = true;
        }

        private void hideNewContext()
        {
            nContext.TopMost = false;
            nContext.Visible = false;
            //nContext.Show();
        }

        private void LoadingImg_Click(object sender, EventArgs e)
        {
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            timerLoading.Stop();
            Dispose();
            lay.Dispose();
            if (hasContext)
            {
                oContext.Visible = false;
                nContext.Visible = true;
                oContext.Hide();
            }
        }
    }
}