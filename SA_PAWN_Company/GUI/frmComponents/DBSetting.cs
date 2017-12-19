using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DataConnection;
using Helpers;

namespace SA_PAWN_Company
{
    public partial class DBSetting : Form
    {
        public DBSetting()
        {
            InitializeComponent();
        }

        private INIParser dbsetting = new INIParser("config.db");

        private void DBSetting_Load(object sender, EventArgs e)
        {
            reloadCheck();
        }

        //AuthType
        private byte cur_auth = 0;

        private string section = "SQL Server Authentication";

        private string section2 = "Windows Authentication";

        private void reloadCheck(byte auth = 0)
        {
            byte type = auth;

            try
            {
                type = byte.Parse(dbsetting.Read("AuthType"));
            }
            catch (Exception)
            {
                type = 0;
            }

            if (type == 0)
            {
                txtServer.Text = dbsetting.Read("hostname", section2);
                Authentication.SelectedIndex = 0;
                UserPassEnable(false);
            }
            else
            {
                setAuthSQL();
                UserPassEnable(true);
            }
        }

        private void setAuthSQL()
        {
            Authentication.SelectedIndex = 1;
            txtServer.Text = dbsetting.Read("hostname", section);
            txtUsername.Text = dbsetting.Read("username", section);
            txtPassword.Text = dbsetting.Read("password", section);
        }

        private void UserPassEnable(bool enable)
        {
            if (enable)
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                lbPass.ForeColor = Color.Black;
                lbUser.ForeColor = Color.Black;
            }
            else
            {
                txtUsername.ResetText();
                txtPassword.ResetText();
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                lbPass.ForeColor = Color.LightGray;
                lbUser.ForeColor = Color.LightGray;
            }
        }

        private void save(byte auth)
        {
            if (auth.Equals(1))
            {
                dbsetting.Write("AuthType", 1 + "");
                dbsetting.Write("hostname", txtServer.Text, section);
                dbsetting.Write("dbname", "SAPAWN", section);
                dbsetting.Write("username", txtUsername.Text, section);
                dbsetting.Write("password", txtPassword.Text, section);
                Connect.Close();
                Connect.Open(dbsetting.Read("hostname"), "SAPAWN", dbsetting.Read("username"), dbsetting.Read("password"));
            }
            else
            {
                dbsetting.Write("AuthType", 0 + "");
                dbsetting.Write("hostname", txtServer.Text, section2);
                dbsetting.Write("dbname", "SAPAWN", section2);
                Connect.Close();
                Connect.Open(dbsetting.Read("hostname"), "SAPAWN");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnApply_Click(null, null);
            btnCancel_Click(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                save((byte)Authentication.SelectedIndex);
                MessageBox.Show("Saved!", "DB Setting");
                reloadCheck();
            }
            catch (Exception)
            {
                MessageBox.Show("Saving error!", "DB Setting");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (cur_auth.Equals(1))
            {
                if (Test.config(txtServer.Text, "SAPAWN", txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("Lo!");
                }
                else
                {
                    MessageBox.Show("LoL!");
                }
            }
            else
            {
                if (Test.config(txtServer.Text, "SAPAWN"))
                {
                    MessageBox.Show("Lo!");
                }
                else
                {
                    MessageBox.Show("LoL!");
                }
            }
        }

        private void Authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Authentication.SelectedIndex == 0)
            {
                txtServer.Text = dbsetting.Read("hostname", section2);
                UserPassEnable(false);
                cur_auth = 0;
            }
            else
            {
                setAuthSQL();
                UserPassEnable(true);
                cur_auth = 1;
            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}