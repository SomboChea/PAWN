using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company.GUI
{
    public partial class frmDashboard2 : Form
    {
        public frmDashboard2()
        {
            InitializeComponent();
        }

        bool open = true;
        private void button1_Click(object sender, EventArgs e)
        {
            panelside.Visible = false;
            panelside.Width = open ? 130 : 43;
            open = !open;
            bunifuTransition1.ShowSync(panelside,true);
        }

        private void frmDashboard2_Load(object sender, EventArgs e)
        {
            int y = 10;
            string[] menus = { "PAWN", "Sell" };
            for(int i=0;i<menus.Length;i++)
            {
                BunifuFlatButton btn = new BunifuFlatButton();
                btn.Text = menus[i];
                btn.Tag = menus[i];
                btn.Location = new Point(10, y);
                btn.Size = new Size(panelside.Width*90/100, 30);
                panelMenu.Controls.Add(btn);           
                y +=35;
            }
        }

    }
}
