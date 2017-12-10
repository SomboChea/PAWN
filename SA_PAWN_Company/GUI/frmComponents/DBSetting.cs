using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace SA_PAWN_Company.GUI
{
    public partial class DBSetting : Form
    {
        public DBSetting()
        {
            InitializeComponent();
            foreach(Control ctrl in Controls)
                if(ctrl is BunifuTextbox)
                {
                    //(BunifuMetroTextbox)ctrl += new EventHandler(bunifuMetroTextbox1_OnValueChanged);
                }
        }

        private void DBSetting_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
