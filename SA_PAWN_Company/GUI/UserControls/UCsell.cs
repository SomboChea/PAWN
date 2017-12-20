using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Helpers;
using DataConnection;
using System.IO;
using System.Threading;

namespace SA_PAWN_Company.GUI
{
    public partial class UCsell : UserControl
    {
        Control[] requirement { get; set; }
        public UCsell()
        {
            InitializeComponent();
            foreach (ColumnHeader each in listView1.Columns)
                each.Width = listView1.Width/3;
            Control[] c = { cbinventoryname, cbinventype,txtprice };
            requirement = c;

            Helper.FillCombobox(cbinventype, "Type", "STID", "Select * from StuffType Where Status=1;");
            listView1.LargeImageList = new ImageList();
            listView1.LargeImageList.ImageSize = new Size(listView1.Width*15/100,listView1.Width*20/100);
            
            clear(this);
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

    
        private object clear(Control mains)
        {
            foreach (Control main in mains.Controls)
            {
                if (main is BunifuCards)
                    clear(main);
                if (main is BunifuMetroTextbox)
                    main.Text = "";
                if (main is ComboBox)
                {
                    try
                    {
                        ((ComboBox)main).SelectedIndex = 0;
                    }
                    catch (Exception) { }
                }

            }
            if (this.Equals(mains))
            {
                foreach (ListViewItem list in listView1.Items)
                {
                    listView1.Items.Remove(list);
                    
                }
            }
            listView1.LargeImageList.Images.Clear();
            txtprice.Text = double.Parse(Connect.ExecuteScalar("Select Price from viewInventory Where SID=" + cbinventoryname.SelectedValue) + "").ToString("#,##0.00");

            btnDelete.Enabled = false;
            
            return null;
        }


        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            clear(this);
            Helper.ClearRedbox(bunifuCards1);
        }

        private void cblisttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = cblisttype.SelectedIndex == 0 ? View.Details : View.LargeIcon;
            foreach (ColumnHeader each in listView1.Columns)
                each.Width = listView1.Width / 3;
            listView1.Columns[3].Width = 0;

        }

        private void cbinventoryname_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtprice.Text = double.Parse( Connect.ExecuteScalar("Select Price from viewInventory Where SID=" + cbinventoryname.SelectedValue) + "").ToString("#,##0.00");
            txtprice.Enabled = txtprice.Text == "";
            string imgname = Connect.ExecuteScalar("Select Photo from viewInventory Where SID=" + cbinventoryname.SelectedValue) + "";
            pictureBox1.Image = File.Exists(Pawnshop.PATH_PREFIX+"Stuff\\" + imgname) ? Image.FromFile(Pawnshop.PATH_PREFIX+"Stuff\\" + imgname) : Properties.Resources.download1;

            foreach(ListViewItem row in listView1.Items)
            {
                bool check = (cbinventype.SelectedValue + "" + cbinventoryname.SelectedValue) == row.SubItems[3].Text;
                if (check)
                {
                    btnAdd.Enabled = false;
                    return;
                }
            }
            btnAdd.Enabled = true;

        }

        private void cbinventype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helper.FillCombobox(cbinventoryname, "Stuff", "SID", "Select * from viewInventory Where STID=" + cbinventype.SelectedValue);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
    
            Helper.CheckRequirement(bunifuCards1, requirement);

            try
            {
                total += double.Parse(txtprice.Text);
            }
            catch (Exception)
            {
                Helper.SetRedbox(txtprice, bunifuCards1);
                return;
            }
            string code = cbinventype.SelectedValue + "" + cbinventoryname.SelectedValue;
            listView1.LargeImageList.Images.Add(code,pictureBox1.Image);
            string[] item = {cbinventoryname.Text,cbinventype.Text,txtprice.Text,(cbinventype.SelectedValue+""+cbinventoryname.SelectedValue) };
            ListViewItem listitem = new ListViewItem(item,listView1.LargeImageList.Images.IndexOfKey(code));
         
            listView1.Items.Add(listitem);



            txttotalqty.Text = listView1.Items.Count+"";
            txtamount.Text = total + " $";
            btnAdd.Enabled = false;
            Helper.ClearRedbox(bunifuCards1);

        }

        double total = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem row = listView1.SelectedItems[0];
                cbinventype.SelectedItem = row.SubItems[0].Text;
                cbinventoryname.SelectedItem = row.SubItems[1].Text;
                txtprice.Text = double.Parse(Connect.ExecuteScalar("Select Price from viewInventory Where SID=" + cbinventoryname.SelectedValue) + "").ToString("#,##0.00");
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
    
        }


        private void UCsell_Load(object sender, EventArgs e)
        {
            //cblisttype.SelectedIndex = 1;
            //ImageList imglist = new ImageList();
            //listView1.LargeImageList = imglist;
            //imglist.Images.Add("hello", pictureBox1.Image);
            ////listView1.LargeImageList.Images.Add("hello", pictureBox1.Image);
            //listView1.Items.Add(new ListViewItem("hello", "hello"));
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Width / 3;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            total -= double.Parse(listView1.SelectedItems[0].SubItems[2].Text);
            listView1.LargeImageList.Images.RemoveByKey(listView1.SelectedItems[0].SubItems[2].Text);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void payment(double pay)
        {
            if (pay < total)
            {
                DialogResult diag=MessageBox.Show("Pay not enough !", "Not enough", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                if (diag == DialogResult.Retry)
                {
                    // Open Form Payagain
                    btnSale_Click(null, null);
                    
                }
                else
                {
                    return;
                }
            }
            else
            {
                double change = pay-total;
                txtreceive.Text = total.ToString("#,##0.00 $");
                txtreturn.Text = change.ToString("#,##0.00 $");
                string sql = "Insert into [Sale](Date,EID,TotalAmount) values(GETDATE(),"+Pawnshop.EmployeeID+","+total+");Select Ident_Current('Sale')";
                int SID=int.Parse(Connect.ExecuteScalar(sql)+"");
                foreach(ListViewItem item in listView1.Items)
                {
                    string InID = item.SubItems[3].Text[1]+"";
                    string changeInventorystatus = "Update Inventory set Status=0 Where InID=" + InID;
                    string exe = "Insert into SaleDetail values(" + SID + "," + InID + ","+item.SubItems[2]+")";
                    Connect.ExecuteNonQuery(sql);
                    Connect.ExecuteNonQuery(changeInventorystatus);
                }
                // Invoice Here
                    // ....


                // Invoice End
                MessageBox.Show("Successful Sold"+Environment.NewLine+"You Must Return :           $ "+change+Environment.NewLine+"Press OK to clear !","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                clear(this);
                
            }
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            frmlistInventory frm = new frmlistInventory();
            DialogResult diag=frm.ShowDialog();
            if (diag == DialogResult.OK)
            {
                cbinventype.SelectedValue = frm.Code[0].ToString();
                cbinventoryname.SelectedValue = frm.Code[1].ToString();
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            tryagain:
            frminputbox inputbox = new frminputbox();
            inputbox.Text = "Get Customer Pay";
            inputbox.lbparam.Text = "Customer Pay : ";
            if (inputbox.ShowDialog() == DialogResult.OK) {
                try
                {
                    payment(double.Parse(inputbox.Value));
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot Get Value !\nPlease Try again later Correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto tryagain;
                }
            };


        }
    }
}
