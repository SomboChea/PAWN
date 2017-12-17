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

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnForceExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataConnection.Connect.Open();
            string fullname="";
            int name = DataConnection.Test.logUser(txtUsername.Text, txtPassword.Text,ref fullname);
            Pawnshop.Fullname = fullname;
            if (name != null)
            {
                frmMain main = new frmMain();
                new Loading(this, main).ShowDialog();
            }
            else
            {
                //new Alert();
            }
        }
    }
}