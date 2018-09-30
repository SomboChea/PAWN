using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DataConnection;

namespace SA_PAWN_Company
{
    public partial class RoleOptionEdit : Form
    {
        private string img_prefix = "IMAGE\\RoleIcons\\";
        //private string[] imgs = { "home", "pawn", "schedule", "sale", "buy", "stuffpawn", "inventory", "customer", "employee", "report", "exit" };

        private List<RoleItem> roles = new List<RoleItem>();

        public string btntext { get; set; }

        public string ID { get; set; }
        public RoleOptionEdit(string id)
        {
            InitializeComponent();
            btnOK.Text = "Update";
            ID = id;
        }
        public RoleOptionEdit()
        {
            InitializeComponent();
            btnOK.Text = "Add";
            DataConnection.Connect.Open();
            itemContainer.AutoScroll = true;
            //loadRoles(1);
        }

        //private void loadRoles(int posID)
        //{
        //    itemContainer.Controls.Clear();
        //    foreach (RoleItem item in getRoles(posID))
        //    {
        //        itemContainer.Controls.Add(item);
        //    }
        //}

        private List<RoleItem> getSelected()
        {
            List<RoleItem> d = new List<RoleItem>();
            foreach (RoleItem itemControl in itemContainer.Controls.OfType<RoleItem>())
            {
                d.Add(itemControl);
            }
            return d;
        }

        //private List<RoleItem> getRoles(int posID)
        //{
        //    string sql = "SELECT * FROM viewOptions";
        //    string sql2 = "SELECT * FROM viewRoleOption WHERE PID = " + posID;
        //    DataTable dt = DataConnection.Connect.GetModel(sql);
        //    DataTable dtByPosID = DataConnection.Connect.GetModel(sql2);

        //    List<RoleItem> lists = new List<RoleItem>();
        //    bool isCheck = false;
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        foreach (DataRow row2 in dtByPosID.Rows)
        //        {
        //            if (row["Tag"] + "" == row2["Tag"] + "")
        //            {
        //                isCheck = true;
        //                break;
        //            }

        //            isCheck = false;
        //        }

        //        RoleItem item = new RoleItem(row["Option_EN"] + "", img_prefix + row["Tag"] + ".png", isCheck);
        //        //item.Nono.Click += new EventHandler(this.clickmsg);
        //        lists.Add(item);
        //    }

        //    return lists;
        //}

        //private void clickmsg(object sender, EventArgs e)
        //{
        //    MessageBox.Show(((Button)sender).Text);
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    loadRoles(1);
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    loadRoles(2);
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    loadRoles(14);
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (RoleItem c in itemContainer.Controls.OfType<RoleItem>())
            {
                s += c.IsCheck + "\n";
            }
            MessageBox.Show(s);
        }

        private void RoleOptionEdit_Load(object sender, EventArgs e)
        {
            if (btntext == "Add")
            {
                DataTable dt = Connect.GetModel("Select * from [Option]");
               foreach(DataRow row in dt.Rows)
                {
                    RoleItem item = new RoleItem(row["Option_EN"]+"", img_prefix + row["Tag"] + ".png");
                    item.Tag = row["OptionID"].ToString();
                    itemContainer.Controls.Add(item);
                }
            }
            else
            {
                DataTable dt = Connect.GetModel("select o.OptionID,r.OptionID as 'Option',Option_EN,RoleID,Tag from [Option] r left JOIN [RoleOption] o on r.OptionID=o.OptionID and RoleID=" + ID);
                foreach (DataRow row in dt.Rows)
                {
                    RoleItem item = new RoleItem(row["Option_EN"] + "", img_prefix + row["Tag"] + ".png",row[0]+""!="");
                    item.Tag = row["Option"].ToString();
                    itemContainer.Controls.Add(item);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btntext = btnOK.Text;
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Cannot be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            int count = 0;
            foreach(RoleItem item in itemContainer.Controls.OfType<RoleItem>())
            {
                if (item.IsCheck == true)
                    count++;
            }
            if (count <1)
            {
                MessageBox.Show("Must Selected Option For role", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }


            if (btntext == "Add")
            {
                if (Connect.ExecuteScalar("Select Position from Position where Position like '" + textBox1.Text.Trim() + "'") + "" != "")
                {
                    MessageBox.Show("Position Existed", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
               
                object pid = Connect.ExecuteScalar("Insert into Position values('" + textBox1.Text + "');Select Ident_current('Position')");
                foreach (RoleItem item in itemContainer.Controls.OfType<RoleItem>())
                {
                    if (!item.IsCheck)
                        continue;
                    string sql = "Insert into RoleOption values(" + pid + ","+item.Tag+")";
                    Connect.ExecuteNonQuery(sql);                  
                }             
            }
            if (btntext == "Update")
            {
                Connect.ExecuteNonQuery("Delete from RoleOption where RoleID=" + ID);
                Connect.ExecuteNonQuery("Update [Position] set Position='"+textBox1.Text.Trim()+"' where PID=" + ID);
                foreach (RoleItem item in itemContainer.Controls.OfType<RoleItem>())
                {
                    if (!item.IsCheck)
                        continue;
                    string sql = "Insert into RoleOption values(" + ID + "," + item.Tag + ")";
                    //MessageBox.Show(ID + "   " + item.Tag + "\n");
                    Connect.ExecuteNonQuery(sql);
                }
            }
            this.Dispose();
        }
    }
}