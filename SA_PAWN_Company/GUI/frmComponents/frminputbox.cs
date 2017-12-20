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
    public partial class frminputbox : Form
    {
        public frminputbox()
        {
            InitializeComponent();
        }

        private void frminputbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult == DialogResult.OK ? DialogResult : DialogResult.Cancel;
        }

        public string Value { get; set; }
        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text.Trim() == "")
            {
                Helpers.Helper.SetRedbox(txtvalue, this);
                txtvalue.Focus();
                return;
            }
            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frminputbox_Load(object sender, EventArgs e)
        {
            //DataConnection.Connect.Open();
            //this.WindowState = FormWindowState.Maximized;
            ////this.IsMdiContainer = true;
            //frmRegisteruser frm = new frmRegisteruser();
            //this.Controls.Add(frm);
            ////frm.MdiParent = this;
            ////frm.WindowState = FormWindowState.Normal;
            ////frm.Show();
        }
    }
}
