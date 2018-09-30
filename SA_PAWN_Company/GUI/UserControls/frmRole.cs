using DataConnection;
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
    public partial class frmRole : Form
    {
        public frmRole()
        {
            InitializeComponent();
            btnup.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count>0)
            {
                btnup.Enabled = true;
            }
            else
            {
                btnup.Enabled = false;
            }
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DataTable dt = Connect.GetModel("Select * from Position");
            foreach (DataRow row in dt.Rows)
            {
                string[] item = { row["PID"].ToString(), row["Position"].ToString() };
                ListViewItem li = new ListViewItem(item);
                listView1.Items.Add(li);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoleOptionEdit frm = new RoleOptionEdit();
            frm.btntext = "Add";
        
            frm.ShowDialog();
            frmRole_Load(null, null);
            this.Show();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnup.Enabled = false;
            RoleOptionEdit frm = new RoleOptionEdit(listView1.SelectedItems[0].SubItems[0].Text);
            frm.btntext = "Update";
            frm.textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            frm.ShowDialog();
            frmRole_Load(null, null);
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
