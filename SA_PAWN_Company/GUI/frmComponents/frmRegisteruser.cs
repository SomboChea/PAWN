using DataConnection;
using Helpers;
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
    public partial class frmRegisteruser : Form
    {
        public Control[] requirement { get; set; }
        public String sql { get; set; } = "";
        public frmRegisteruser()
        {
            InitializeComponent();
            Control[] req = { txtpass, txtrepass, txtusername };
            requirement = req;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if(!Helper.CheckRequirement(this, requirement))
                return;
            if(txtpass.Text!=txtrepass.Text)
            {
                Helper.SetRedbox(txtrepass, this);
                MessageBox.Show("Password not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(Connect.GetModel("Select * from [User] Where Username='" + txtusername.Text.Trim() + "'").Rows.Count > 0)
            {
                Helper.SetRedbox(txtusername, this);
                MessageBox.Show("Username Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "Insert into [User] values('"+txtusername.Text.Trim()+"','"+txtpass.Text.Trim()+"',"+1+")";


        }
    }
}
