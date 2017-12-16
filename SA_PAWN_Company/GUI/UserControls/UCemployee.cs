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
        }

        Control[] requirement;
        DataTable dt;
        private void Reload()
        {
            dt = Connect.GetModel("SELECT EID,v.Name,v.Gender, v.Email,v.Address,v.Salary ,v.Tel,v.Position,v.Username FROM viewEmployee v");
                dgEmployee.DataSource = dt;
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
            Helper.ClearRedbox(this);
            btnadd.Text = "ADD Employee";
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

                picturebox.Image = File.Exists(Pawnshop.PATH_PREFIX + row["Photo"]) ? Image.FromFile(@"./image/" + row["Photo"]) : Properties.Resources.Simpleicons_Interface_business_man_1_svg;
                foreach (Control ctrl in groupBox1.Controls)
                {
                    try
                    {
                        ctrl.Text = row[ctrl.Tag + ""] + "";
                    }
                    catch (Exception ex) {
                    }
                }
                btnadd.Text = "UPDATE Employee";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckRequirement(groupBox1,requirement))
                return;

        }
    }
}
