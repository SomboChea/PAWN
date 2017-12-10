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
    public partial class UCconvert : UserControl
    {
        public UCconvert()
        {
            InitializeComponent();
        }
        Panel MainPanel;
        public UCconvert(Panel panel)
        {
            InitializeComponent();
            MainPanel = panel;
        }


        private void UCconvert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Remove(this);
        }
    }
}
