using Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class frmMain : Form
    {
        private int userID;
        private string searchString = null;

        public frmMain()
        {
            InitializeComponent();
            FullMode.Fullscreen(this);
            panMenu.AutoScroll = true;
        }

        public frmMain(int userID, string Name = null)
        {
            InitializeComponent();
            FullMode.Fullscreen(this);

            Name = Pawnshop.Fullname;
            DataConnection.Connect.Open();
            this.userID = userID;
            lbUsername.Text = !Name.Equals(null) ? Name : "Undefined";
            getTags();
            loadMenu(userID);

            //panContent.Controls.Add(new UCMain());
            OpenUC(new UCMain());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        /** Minimized Button **/

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool open = true;

        /** Open / Close Menu **/

        private void btnNav_Click(object sender, EventArgs e)
        {
            panNav.Visible = false;
            panNav.Width = open ? 0 : 269;
            open = !open;
            bTran.ShowSync(panNav, true, null);
        }

        /** Tags **/
        private List<string> tags = new List<string>();

        private void getTags()
        {
            foreach (Bunifu.Framework.UI.BunifuFlatButton tag in panMenu.Controls.OfType<Bunifu.Framework.UI.BunifuFlatButton>())
            {
                tags.Add(tag.Tag + "");
            }
        }

        /** Get user tags **/

        private List<string> getUserTags(int roleID)
        {
            List<string> list = new List<string>();
            DataTable d = DataConnection.Connect.GetModel("SELECT Tag FROM viewRoleOption WHERE PID = " + roleID);
            foreach (DataRow row in d.Rows)
                list.Add(row["Tag"] + "");
            return list;
        }

        /** List Menu **/

        private void loadMenu(int id)
        {
            int role_id = int.Parse(DataConnection.Connect.ExecuteScalar("EXEC getUserRole " + id) + "");
            List<string> list = getUserTags(role_id);
            for (int i = 0; i < list.Count; i++)
            {
                foreach (Bunifu.Framework.UI.BunifuFlatButton tag in panMenu.Controls.OfType<Bunifu.Framework.UI.BunifuFlatButton>())
                {
                    if (list[i] == tag.Tag.ToString())
                        tag.Visible = true;
                }
            }
        }

        /** Sign Out **/

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            //App.ExitThread(this);
            //App.Open(new Login());
        }

        /** Dashboard **/

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenUC(new UCMain());
            lbTitle.Text = "Dashboard";
        }

        /** New Panw **/

        private void btnNewPawn_Click(object sender, EventArgs e)
        {
            OpenUC(new UCPawn());
            lbTitle.Text = "New Pawn";
        }

        /** Open Stuff **/

        private void btnStuff_Click(object sender, EventArgs e)
        {
            OpenUC(new UCStuff());
            panSearch.Visible = true;
            lbTitle.Text = "Stuff Pawned";
        }

        private void loadUCStuff()
        {
            OpenUC(new UCStuff(searchString));
            lbTitle.Text = "Stuff Pawned : Search for '" + searchString + "'";
        }

        /** Open Inventory **/

        private void btnInventory_Click(object sender, EventArgs e)
        {
            OpenUC(new UCinventory());
            lbTitle.Text = "Inventory";
        }

        /** Open Customers **/

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenUC(new UCcustomer());
            lbTitle.Text = "Customers";
        }

        /** Open Employees **/

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenUC(new UCemployee2());
            lbTitle.Text = "Employees";
        }

        /** Open Reports **/

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenUC(new UcReports());
            lbTitle.Text = "Reports";
        }

        /** Open new UserControl **/

        private void OpenUC(UserControl uc)
        {
            panContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panContent.Controls.Add(uc);
            panSearch.Visible = false;
        }

        /** Schedule Lists **/

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenUC(new ScheduleList());
            lbTitle.Text = "Schedule Lists";
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            OpenUC(new UCsell());
            lbTitle.Text = "Sales Inventory";
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            OpenUC(new UCbuy());
            lbTitle.Text = "Buy Inventory";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchString = txtSearch.Text.Trim();
            if (searchString != null || searchString != "")
                loadUCStuff();

            if (txtSearch.TextLength <= 0)
            {
                OpenUC(new UCStuff());
                lbTitle.Text = "Stuff Pawned";
            }
            panSearch.Visible = true;
        }
    }
}