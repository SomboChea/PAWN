using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Helpers;
using MetroFramework.Controls;
using DataConnection;

namespace SA_PAWN_Company.GUI
{
    public partial class UCbuy : UserControl
    {
        Control[] requirement;
        public UCbuy()
        {
            InitializeComponent();
            Control[] ct = { txtname, txtcost, txtprice, cbtype };
            requirement = ct;
            //btnClear_Click(null,null);
            cbtype.SelectedItem = "dsds";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image PNG (*.png)|*.png|Image JPG (*.jpg)|*.png";
            opf.Title = "Browse Product Image ...";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imgpath = opf.FileName;
                pictureBox1.Image = Image.FromFile(imgpath);
            }
        }
        public string imgpath { get; set; } = "";
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckRequirement(groupBox1, requirement))
            {
                return;
            }
            if (!Helper.CheckDouble(groupBox1, txtprice,txtcost))
            {
                return;
            }


            string imgname= imgpath==""?"": Helper.Upload_Photo(imgpath, Pawnshop.PATH_PREFIX + "Stuff\\");
            int BID = int.Parse(Connect.ExecuteScalar("Insert Into Buy([Date],[EID]) values(GETDATE(),"+Pawnshop.EmployeeID+");Select Scope_identity()") + "");
            int SID = int.Parse(Connect.ExecuteScalar("Insert into Stuff values('"+txtname.Text.Trim()+"',"+cbtype.SelectedValue+",'"+imgname+"');Select Scope_Identity();")+"");
            int InvID=int.Parse(Connect.ExecuteScalar("Insert into Inventory values("+SID+",'"+txtprice.Text.Trim()+"',1);Select Scope_identity();")+"");
            Connect.ExecuteNonQuery("Insert into BuyDetail values("+BID+"," + InvID + "," + txtcost.Text + ")");
            //MessageBox.Show(imgname+"");

            btnClear_Click(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Helper.ClearRedbox(groupBox1);
            foreach(Control ctrl in groupBox1.Controls)
            {
                if (ctrl is MetroTextBox)
                    ((MetroTextBox)ctrl).Text = "";
                else if (ctrl is MetroComboBox)
                {
                    try
                    {
                        ((MetroComboBox)ctrl).SelectedIndex = 0;
                    }
                    catch (Exception) { }
                }
                pictureBox1.Image = Properties.Resources.download1;
                Helper.FillCombobox(cbtype, "Type", "STID", "Select * from StuffType");
                imgpath = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frminputbox inputbox = new frminputbox();
            inputbox.Text = "Add Inventory Type";
            inputbox.lbparam.Text = "Inventory Type Name :";
            if (inputbox.ShowDialog() == DialogResult.OK)
            {
                Connect.ExecuteNonQuery("Insert Into StuffType Values('"+inputbox.Value+"',1)");
                Helper.FillCombobox(cbtype, "Type", "STID", "Select * from StuffType");
            }
        }

        private void UCbuy_Load(object sender, EventArgs e)
        {

        }
    }
}
