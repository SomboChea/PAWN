using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company.GUI
{
    public partial class UCinventory : UserControl
    {
        public UCinventory()
        {
            InitializeComponent();
        }

        Panel MainPanel;
        public UCinventory(Panel panel)
        {
            InitializeComponent();
            MainPanel = panel;
        }

        private void UCinventory_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UCconvert uc = new UCconvert(MainPanel);       
            MainPanel.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
