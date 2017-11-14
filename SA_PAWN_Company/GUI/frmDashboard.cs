using MetroFramework.Forms;
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

namespace SA_PAWN_Company.GUI
{
    public partial class frmDashboard : MetroForm
    {
        public frmDashboard()
        {
            InitializeComponent();
      
            panelside.Size = new Size(this.Size.Width * 20/100,this.Size.Height);
            toolStrip1.Size = new Size(panelside.Size.Width, toolStrip1.Size.Height);
            //toolStripButton2.Size = new Size(toolStrip1.Size.Width * 90 / 100, toolStrip1.Size.Width * 90 / 100);
            //toolStrip1.ImageScalingSize = new Size(100,  100);
            //toolStrip1.ImageScalingSize = new Size(300, 300);
            //toolStrip1.Refresh();
            //this.Refresh();
    
            foreach (ToolStripButton temp in toolStrip1.Items)
            {
                //temp.ImageScaling = ToolStripItemImageScaling.None;
                temp.AutoSize = false;
                temp.Size = new Size(panelside.Width*90/100, panelside.Width * 90 / 100);
              
            }

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btntoggle_Click(object sender, EventArgs e)
        {
            // Way One
            bool panelstatus = panel2.Location.X > 10;
            for (int i = panelside.Width; i > 0; i--)
            {
                panel2.Width+=panelstatus?1:-1;
                panel2.Location = new Point(panel2.Location.X -(panelstatus?1:-1), panel2.Location.Y);
                //panelside.Width--;
                Thread.Sleep(10);
            }

            // Way Two

            //for (int i = panelside.Width; i > 0; i--)
            //{
            //    panelside.Width--;
            //}


            // panelside.Width = 1;
            // toolStrip1.Location = new Point(-30, 0);


        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
