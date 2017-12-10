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
    public partial class UCpawn : UserControl
    {
        Panel MainPanel;
        public UCpawn()
        {
            InitializeComponent();
        }
        public UCpawn(Panel panel)
        {
            InitializeComponent();
            MainPanel = panel;
        }

        private void UCpawn_Load(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Remove(this);
            MainPanel.Controls.Add(new GUI.Hilux.UCemployee());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
