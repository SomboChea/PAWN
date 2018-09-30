using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataConnection;

namespace SA_PAWN_Company
{
    public partial class UCemployee2 : UserControl
    {
        public UCemployee2()
        {
            InitializeComponent();
        }

        void btnadd_add()
        {
            Button btnadd = new Button();
            btnadd.Size = new Size(400, 246);
            btnadd.BackColor = Color.Blue;
            btnadd.Margin = new Padding(10);
            btnadd.BackgroundImage = Properties.Resources.add_documents_1_;
            btnadd.BackgroundImageLayout = ImageLayout.Zoom;
            btnadd.Click += new EventHandler(btnAdd_Click);
            panel.Controls.Add(btnadd);
        }

        private void UCemployee2_Load(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            btnadd_add();

            DataTable dt = Connect.GetModel("Select * from viewEmployee order by EID Desc");
    
            foreach (DataRow row in dt.Rows)
            {
                blockEmployee block = new blockEmployee();
                block.name = row["Name"] + "";
                block.id = row["EID"] + "";
                block.gender = row["Gender"].ToString();
                block.salary = double.Parse(row["Salary"].ToString()).ToString("#,##0.00");
                block.imgname = row["Photo"].ToString();
                block.position = row["Position"].ToString();
                block.Margin = new Padding(10);
                block.btndel.Click += new EventHandler(this.btnDel_Click);
                block.btnEdit.Click += new EventHandler(btnup_Click);
                panel.Controls.Add(block);              
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).Tag + "";
            frmEmployee frm = new frmEmployee();
            frm.ShowDialog();

            UCemployee2_Load(null, null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).Tag + "";
            string msg = Connect.ExecuteNonQuery("Update Employee set Status=0 Where EID=" + id) ? "Delete Success" : "Delete Failed";
            MessageBox.Show(msg, "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UCemployee2_Load(null, null);
        }
        private void btnup_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).Tag + "";
            //Code
            frmEmployee frm = new frmEmployee(id);
            frm.ShowDialog();
            // End Code
            UCemployee2_Load(null, null);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
