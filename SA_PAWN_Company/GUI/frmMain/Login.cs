using IniParser;
using IniParser.Model;
using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Helpers;
using DataConnection;

namespace SA_PAWN_Company
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;
            FullMode.Fullscreen(this);
            openCon();
        }

        /** Instance Declared Variables **/
        private int user_id;
        private string user_name;

        private INIParser chk = new INIParser("config.db");
        private string section3 = "SQL Server Authentication";
        private string section2 = "Windows Authentication";

        private void openCon()
        {
            try
            {
                if (chk.Read("AuthType") == "0")
                {
                    Connect.Open(chk.Read("hostname", section2), "SAPAWN");
                }
                else
                {
                    Connect.Open(chk.Read("hostname", section3), "SAPAWN", chk.Read("username", section3), chk.Read("password", section3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (checkRem())
                AutoLogin();
        }

        private void btnForceExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            AutoLogin();
        }

        /** Check Auto Login **/

        private void AutoLogin()
        {
            if (SubmitLogin())
                loadMain();
        }

        /** Login Submit **/

        private bool SubmitLogin()
        {
            user_id = DataConnection.Test.logUser(txtUsername.Text, txtPassword.Text, ref user_name);
            if (user_name != null && !user_id.Equals(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /** Load Dashboard **/

        private void loadMain()
        {
            frmMain main = new frmMain(user_id, user_name);
            new Loading(this, main).ShowDialog();
        }

        /** Message Error **/

        private void MsgErr()
        {
            MessageBox.Show("Error!");
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            AutoLogin();
        }

        private INIParser rem = new INIParser("config.db");
        private string section = "Remmeber Login";

        private void rememberCheck_OnChange(object sender, EventArgs e)
        {
            bool re = rememberCheck.Checked ? true : false;
            if (re)
            {
                rem.Write("Username", txtUsername.Text, section);
                rem.Write("Password", txtPassword.Text, section);
            }
            else
            {
                rem.DeleteSection(section);
            }
        }

        private bool checkRem()
        {
            if (rem.KeyExists("Username", section) && rem.KeyExists("Password", section))
            {
                rememberCheck.Checked = true;
                txtUsername.Text = rem.Read("Username", section);
                txtPassword.Text = rem.Read("Password", section);
                return true;
            }
            else
            {
                rememberCheck.Checked = false;
                return false;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new DBSetting().ShowDialog();
        }
    }
}