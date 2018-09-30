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
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();

            bool chk = Boolean.Parse(settings.Read("AutoWriteOff", "AdminSettings"));
            if (chk)
            {
                txtDay.Enabled = true;
                txtDay.Text = settings.Read("DayToBe", "AdminSettings");
                rOn.Checked = true;
            }
            else
            {
                txtDay.Enabled = false;
                txtDay.Text = settings.Read("DayToBe", "AdminSettings");
                rOff.Checked = true;
            }
        }

        private Helpers.INIParser settings = new Helpers.INIParser("config.db");

        private void rOff_CheckedChanged(object sender, EventArgs e)
        {
            txtDay.Enabled = false;
        }

        private void rOn_CheckedChanged(object sender, EventArgs e)
        {
            txtDay.Enabled = true;
        }

        private void save()
        {
            if (rOn.Checked)
            {
                try
                {
                    int test = int.Parse(txtDay.Text.Trim());
                    settings.Write("AutoWriteOff", "true", "AdminSettings");
                    settings.Write("DayToBe", txtDay.Text, "AdminSettings");
                }
                catch (Exception ex)
                {
                    this.txtDay.Text = 0 + "";
                    MessageBox.Show("Please enter a correct days!");
                    return;
                }
            }
            else
            {
                settings.Write("AutoWriteOff", "false", "AdminSettings");
                settings.Write("DayToBe", txtDay.Text, "AdminSettings");
            }
        }
    }
}