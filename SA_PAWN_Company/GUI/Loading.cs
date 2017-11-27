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
    public partial class Loading : Form
    {
        Form oContext, nContext;
        bool hasContext = false;

        public Loading()
        {
            InitializeComponent();
            this.ControlBox = false;
            timerLoading.Start();
            TopMost = true;
            TopLevel = true;
            hasContext = false;
        }
        
        public Loading(Form oldContext, Form newContext, int interval=2000)
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

            //
            oContext.TopMost = true;
            nContext.Show();
           // nContext.Visible = false;   
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            timerLoading.Stop();
            Dispose();
            
            if(hasContext)
            {
                oContext.Visible = false;
                //nContext.Show();
                nContext.Visible = true;
                oContext.Hide();
            }
        }

    }
}
