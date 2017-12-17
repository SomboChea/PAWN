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
using MetroFramework.Controls;
using Helpers;
using System.IO;

namespace SA_PAWN_Company
{
    public partial class UCemployee : UserControl
    {
        public UCemployee()
        {
            InitializeComponent();
            
            Reload();
            Control[] ct = { txtname,txtphone,txtaddress,txtsalary,cbposition};
            requirement = ct;
            //Helper.SetRedbox(txtname, groupBox1);
            //MessageBox.Show(groupBox1.Controls.Count + "");
    
            
        }

        Control[] requirement;
        DataTable dt;
        private void Reload()
        {
            dt = Connect.GetModel("SELECT EID,v.Name,v.Gender, v.Email,v.Address,v.Salary ,v.Tel,v.Position,v.Username,Photo,UserEID FROM viewEmployee v");
            dgEmployee.DataSource = dt;
            dgEmployee.Columns["Photo"].Visible = false;
            dgEmployee.Columns["UserEID"].Visible = false;
            Helper.FillCombobox(cbposition,"Position", "PID", "Select * from Position");

            foreach(Control temp in groupBox1.Controls)
            {                
                if (temp is MetroTextBox)
                    temp.Text = "";
                if (temp is MetroComboBox)
                    ((MetroComboBox)temp).SelectedIndex = 0;                
            }
            rmale.Checked = true;
            picturebox.Image = Properties.Resources.Simpleicons_Interface_business_man_1_svg;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Reload();
            
            Helper.ClearRedbox(groupBox1);
            btnadd.Text = "ADD Employee";
            btnAdduser.Text = "Add User";
            btnAdduser.BackColor = Color.Blue;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void UCemployee_Load(object sender, EventArgs e)
        {
        }

        private void chkactive_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dgEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgEmployee_Click(object sender, EventArgs e)
        {
            if (dgEmployee.SelectedRows.Count > 0)
            {
                DataRow row = dt.Rows[dgEmployee.SelectedRows[0].Index];

                picturebox.Image = File.Exists(Pawnshop.PATH_PREFIX + "Customers\\" + row["Photo"]) ? Image.FromFile(Pawnshop.PATH_PREFIX + "Customers\\" + row["Photo"]) : Properties.Resources.Simpleicons_Interface_business_man_1_svg;
                foreach (Control ctrl in groupBox1.Controls)
                {
                    try
                    {
                        ctrl.Text = row[ctrl.Tag + ""] + "";
                    }
                    catch (Exception ex)
                    {
                    }
                }
                btnadd.Text = "UPDATE Employee";
                if (!row["UserEID"].ToString().Equals(""))
                {
                    btnAdduser.Text = "Delete User";
                    btnAdduser.BackColor = Color.Red;
                }
                else
                {
                    btnAdduser.Text = "Add User";
                    btnAdduser.BackColor = Color.Blue;
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckRequirement(groupBox1,requirement))
                return;
            try
            {
                double.Parse(txtsalary.Text);
            }
            catch(Exception)
            { Helper.SetRedbox(txtsalary, groupBox1);return; }
            if (btnadd.Text == "Add Employee")
            {
                string sql = "Insert into Employee values(@obj1,@obj2,@obj3,@obj4,@obj5,@obj6,@obj7,1,@obj8);";
                object[] objs= { txtname.Text, rmale.Checked ? "Male" : "Female", txtaddress.Text, txtemail.Text, txtphone.Text, txtsalary.Text, imgname, cbposition.SelectedValue};
                Connect.ExecuteNonQuery(sql+additionSql,Connect.GetParams(objs));
            }
            else
            {
                string sql = "update Employee set Name=@obj1,Gender=@obj2,Address=@obj3,Email=@obj4,Tel=@obj5,Salary=@obj6,Photo=@obj7,PID=@obj8  Where EID=" + dgEmployee.SelectedRows[0].Cells[0].Value;
                object[] objs = { txtname.Text, rmale.Checked ? "Male" : "Female", txtaddress.Text, txtemail.Text, txtphone.Text, txtsalary.Text, imgname, cbposition.SelectedValue };
                Connect.ExecuteNonQuery(sql + additionSql, Connect.GetParams(objs));
            }
            button8_Click(null, null);
        }

        string additionSql = "";
        private void btnaddpos_Click(object sender, EventArgs e)
        {
            frmAddPos frm = new frmAddPos();
            frm.ShowDialog();
           
            Helper.FillCombobox(cbposition, "Position", "PID", "Select * from Position");
        }

        string imgpath = "";
        string imgname = "";
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = false;
            opf.Filter = "Image File (*.JPEG)|*.jpeg|Image File(*.jpg)|*.jpg|PNG File (*.png)|*.png";
            DialogResult diag = opf.ShowDialog();
            if (diag == DialogResult.OK)
            {
                imgpath = opf.FileName;
                imgname = opf.SafeFileName;
                int index = 1;
                if(!Directory.Exists(Pawnshop.PATH_PREFIX + "Customers\\"))
                    Directory.CreateDirectory(Pawnshop.PATH_PREFIX + "Customers\\");
                while(File.Exists(Pawnshop.PATH_PREFIX + "Customers\\" + imgname))
                {
                    imgname = imgname.Split('.')[0] +"_Copy-"+ index + '.' + imgname.Split('.')[1];
                    index++;
                }
                File.Copy(imgpath, Pawnshop.PATH_PREFIX + "Customers\\"+imgname);
                picturebox.Image = Image.FromFile(Pawnshop.PATH_PREFIX + "Customers\\" + imgname);
            }
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            if (btnAdduser.Text == "Add User")
            {
                frmRegisteruser frm = new frmRegisteruser();
                frm.ShowDialog();
                additionSql = frm.sql;
                if (frm.sql != "")
                {
                    btnAdduser.Text = "Delete User";
                    btnAdduser.BackColor = Color.Red;
                }
            }
            else
            {
                Connect.ExecuteNonQuery("Delete from [User] where EID=" + dgEmployee.SelectedRows[0].Cells[0].Value);
                btnAdduser.Text = "Add User";
                btnAdduser.BackColor = Color.Blue;
                Helper.FillDatagridview(dgEmployee, "SELECT EID,v.Name,v.Gender, v.Email,v.Address,v.Salary ,v.Tel,v.Position,v.Username,Photo,UserEID FROM viewEmployee v");
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
