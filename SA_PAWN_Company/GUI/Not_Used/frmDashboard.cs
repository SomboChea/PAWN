using DataConnection;
using Helpers;
using MetroFramework.Forms;
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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            //panelside.Size = new Size(this.Size.Width * 15 / 100, this.Size.Height);
            //toolStrip1.Size = new Size(panelside.Size.Width, toolStrip1.Size.Height);
            ////toolStripButton2.Size = new Size(toolStrip1.Size.Width * 90 / 100, toolStrip1.Size.Width * 90 / 100);
            ////toolStrip1.ImageScalingSize = new Size(100,  100);
            ////toolStrip1.ImageScalingSize = new Size(300, 300);
            ////toolStrip1.Refresh();
            ////this.Refresh();
            ////toolStripButton1.Alignment = ToolStripItemAlignment.Right;

            //foreach (ToolStripButton temp in toolStrip1.Items)
            //{
            //    //temp.Alignment = ToolStripItemAlignment.Right;
            //    //temp.ImageScaling = ToolStripItemImageScaling.None;
            //    temp.AutoSize = false;
            //    temp.Size = new Size(panelside.Width * 90 / 100, panelside.Width * 90 / 100);
            //    temp.CheckOnClick = false;
            //}

            ////UserControl uc = new UCpawn(panelMain);
            ////uc.Dock = DockStyle.Fill;
            ////panelMain.Controls.Add(uc);
Connect.Open();
            panelMain.Controls.Add(new UCbuy());
            panelMain.AutoScroll = true;
            
        }

        public static Panel MainPanel;

        private void frmDashboard_Load(object sender, EventArgs e)
        {
        }

        private bool Sidebaropen = true;

        private void btntoggle_Click(object sender, EventArgs e)
        {
            //////////////////////////////////
            //// Way One
            ////bool panelstatus = panel2.Location.X > 10;
            //for (int i = panelside.Width; i > -20; i--)
            //{
            //    panel2.Width += Sidebaropen ? 1 : -1;
            //    panel2.Location = new Point(panel2.Location.X - (Sidebaropen ? 1 : -1), panel2.Location.Y);
            //    //panelside.Width--;
            //    //if (i < 100)
            //    //{
            //    //    foreach (ToolStripButton temp in toolStrip1.Items)
            //    //    {
            //    //        //temp.ImageScaling = ToolStripItemImageScaling.None;
            //    //        //temp.AutoSize = false;
            //    //        btntoggle.Text = temp.Size.Width + "";
            //    //        temp.Size = new Size(temp.Size.Width - 1, temp.Size.Height - 1);

            //    //        temp.DisplayStyle = Sidebaropen?ToolStripItemDisplayStyle.ImageAndText: ToolStripItemDisplayStyle.Image;
            //    //    }
            //    //}
            //    Thread.Sleep(1 / 3);
            //}
            //btntoggle.Text = !Sidebaropen ? "<<<<<<<<<<<<<<<<<" : ">>>>>>>>>>>>>";
            //Sidebaropen = !Sidebaropen;
            /////////////////////////

            ///////////////////////////
            //// Way Two
            ////for (int i = panelside.Width; i > 0; i--)
            ////{
            ////    panelside.Width--;
            ////}
            ///////////////////////////

            //// panelside.Width = 1;
            //// toolStrip1.Location = new Point(-30, 0);
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //UserControl UC;

            //switch (e.ClickedItem.Text)
            //{
            //    case "Pawn":
            //        UC = new GUI.Hilux.UCemployee();
            //        break;

            //    case "Employee":
            //        UC = new GUI.Hilux.UCemployee();
            //        break;

            //    case "Buy":
            //        UC = new UCbuy();
            //        break;

            //    case "Inventory":
            //        UC = new UCinventory(panelMain);
            //        break;

            //    case "Holiday":
            //        UC = new UCHoliday();
            //        break;

            //    case "Report":
            //        UC = new UCReport();
            //        break;

            //    case "Sale":
            //        UC = new UCsell();
            //        break;

            //    case "Account":
            //        UC = new UCaccount();
            //        break;

            //    default:
            //        UC = new UserControl();
            //        break;
            //}

            //UC.Dock = DockStyle.Fill;
            //foreach (ToolStripButton temp in toolStrip1.Items)
            //{
            //    if (temp.Text == e.ClickedItem.Text)
            //    {
            //        temp.Checked = true;
            //        continue;
            //    }
            //    temp.Checked = false;
            //}
            //foreach (Control c in UC.Controls)
            //    c.Anchor = AnchorStyles.Top;

            //foreach (Control temp in this.panelMain.Controls.OfType<UserControl>())
            //{
            //    this.panelMain.Controls.Remove(temp);
            //}
            //panelMain.Controls.Add(UC);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void btnPawn_Click(object sender, EventArgs e)
        {
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}