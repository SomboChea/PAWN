using Helpers;
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
    public partial class frmMain : Form
    {
        private int userID;

        public frmMain()
        {
            InitializeComponent();
            FullMode.Fullscreen(this);
        }

        public frmMain(int userID, string Name = null)
        {
            InitializeComponent();
            FullMode.Fullscreen(this);

            DataConnection.Connect.Open();
            this.userID = userID;
            lbUsername.Text = !Name.Equals(null) ? Name : "Undefined";
            getTags();
            loadMenu(userID);

            panContent.Controls.Add(new UCMain());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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
            panNav.Width = open ? 0 : 258;
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
        }

        /** New Panw **/

        private void btnNewPawn_Click(object sender, EventArgs e)
        {
            panContent.Controls.Clear();
            panContent.Controls.Add(new UCPawn());
        }

        /** Open Stuff **/

        private void btnStuff_Click(object sender, EventArgs e)
        {
        }

        /** Open Inventory **/

        private void btnInventory_Click(object sender, EventArgs e)
        {
        }

        /** Open Customers **/

        private void btnCustomers_Click(object sender, EventArgs e)
        {
        }

        /** Open Employees **/

        private void btnEmployees_Click(object sender, EventArgs e)
        {
        }

        /** Open Reports **/

        private void btnReports_Click(object sender, EventArgs e)
        {
        }

        /** Holidays **/

        private void btnHoliday_Click(object sender, EventArgs e)
        {
        }
    }
}