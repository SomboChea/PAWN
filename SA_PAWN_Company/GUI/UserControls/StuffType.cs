using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;

namespace SA_PAWN_Company
{
    public partial class StuffType : Form
    {
        public StuffType()
        {
            InitializeComponent();
            FullMode.PopUp(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataConnection.Connect.Open();
            bool s = true;//DataConnection.Connect.ExecuteNonQuery("INSERT INTO StuffType(Type, Status) VALUES('" + txtStuffType.Text + "',1);");
            if (!s)
                MessageBox.Show("Error Add Stuff Type!");
            else
                this.Dispose();
        }
    }
}