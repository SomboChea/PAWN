using IniParser;
using IniParser.Model;
using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
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

using Helpers;
using SA_PAWN_Company.GUI;

namespace SA_PAWN_Company
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;
            FullMode.Fullscreen(this);
        }

        /** Instance Declared Variables **/
        private int user_id;
        private string user_name;

        private void Login_Load(object sender, EventArgs e)
        {
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
            DataConnection.Connect.Open();

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
            this.Hide();
            new Loading(this, new frmMain(user_id, user_name)).ShowDialog();
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
    }
}