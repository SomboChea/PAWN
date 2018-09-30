using DataConnection;
using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            label1.Text = "Add New Employee";
            btnok.Text = "Add";
        }

        public string ID { get; set; }

        public frmEmployee(string id)
        {
            InitializeComponent();
            ID = id;
            label1.Text = "Edit User ID : " + id;
            btnok.Text = "Update";
            DataTable d = Connect.GetModel("Select * from viewEmployee where EID=" + id);
            DataRow row = d.Rows[0];
            pictureBox1.Image = File.Exists(Pawnshop.PATH_PREFIX + "Employee\\" + row["Photo"]) ? Image.FromFile(Pawnshop.PATH_PREFIX + "Employee\\" + row["Photo"]) : Properties.Resources.Simpleicons_Interface_business_man_1_svg;
            foreach (Control c in Controls)
            {
                try
                {
                    c.Text = row[c.Tag + ""].ToString();
                }
                catch (Exception) { }
            }
            name = txtname.Text;
        }

        public Control[] Require { get; set; }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            Control[] c = { txtaddress, txtconfirm, txtemail, txtname, txtpass, txtsalary, txttel, txtuser, cbposition };
            Require = c;

            Helper.FillCombobox(cbposition, "Position", "PID", "Select * from Position");
            try
            {
                cbposition.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        public string imgpath { get; set; }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image File(*.jpg)|*.jpg|PNG FILE (*.png)|*.png";
            opf.Title = "Browse Employee Image";
            opf.Multiselect = false;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imgpath = opf.FileName;
                pictureBox1.ImageLocation = imgpath;
            }
        }

        public string name { get; set; }

        private void btnok_Click(object sender, EventArgs e)
        {
            Helper.ClearRedbox(this);
            if (!Helper.CheckRequirement(this, Require))
                return;
            if (!Helper.CheckDouble(this, txtsalary))
                return;
            if (txtpass.Text.Trim() != txtconfirm.Text.Trim())
            {
                Helper.SetRedbox(txtconfirm, this);
                MessageBox.Show("Password Not Match", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (name != txtname.Text.Trim() && Connect.ExecuteScalar("Select Name from Employee where Status=1 and Name like '" + txtname.Text.Trim() + "'") != null)
            {
                Helper.SetRedbox(txtname, this);
                MessageBox.Show("Name Exist", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            string imgname = "";
            if (imgpath != null)
            {
                imgname = Helper.Upload_Photo(imgpath, Pawnshop.PATH_PREFIX + "Employee\\");
            }
            if (btnok.Text == "Add")
            {
                string sql = "Insert into Employee(Name,Gender,Address,Email,Tel,Salary,Photo,Status,PID) values(@obj1,@obj2,@obj3,@obj4,@obj5,@obj6,@obj7,1,@obj8)";
                object[] param = { txtname.Text, cbgender.Text, txtaddress.Text, txtemail.Text, txttel.Text, txtsalary.Text, imgname, cbposition.SelectedValue };
                Connect.ExecuteNonQuery(sql, Connect.GetParams(param));
                string EID = "" + Connect.ExecuteScalar("select IDENT_CURRENT('Employee')");
                sql = "Insert into [User](Username,Password,Status,EID) values(@obj1,@obj2,1,@obj3)";
                object[] param2 = { txtuser.Text, txtpass.Text, EID };
                Connect.ExecuteNonQuery(sql, Connect.GetParams(param2));
            }
            if (btnok.Text == "Update")
            {
                // MessageBox.Show("dsdsd");
                string sql = "update Employee set Name=@obj1, Gender=@obj2, Address=@obj3, Email=@obj4, Tel=@obj5, Salary=@obj6, Photo=@obj7, PID=@obj8 where EID=" + ID;
                object[] param = { txtname.Text, cbgender.Text, txtaddress.Text, txtemail.Text, txttel.Text, txtsalary.Text, imgname, cbposition.SelectedValue };
                Connect.ExecuteNonQuery(sql, Connect.GetParams(param));
                sql = "update [User] set Username=@obj1, Password=@obj2 where EID=" + ID;
                object[] param2 = { txtuser.Text, txtpass.Text };
                Connect.ExecuteNonQuery(sql, Connect.GetParams(param2));
            }
            this.Dispose();
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //new frmAddPos().ShowDialog();
            new frmRole().ShowDialog();
        }
    }
}