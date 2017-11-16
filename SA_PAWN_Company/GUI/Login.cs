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

namespace SA_PAWN_Company
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////////////////////////////
            // way one : JSON (Combobox1)
            string jsontext = File.ReadAllText(@"D:\SN1.2 C#\PAWN\Language\" + comboBox1.Text + ".json");
            JObject json = JObject.Parse(jsontext);
            JArray jarr = new JArray();
            foreach (Control ctrl in Controls)
            {
                try
                {
                        ctrl.Text = json[ctrl.Tag].ToString();                 
                }
                catch (Exception) { }
            }
            /////////////////////////////////



       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///////////////////////////////////////
            // Combobox2 : INIparser
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(@"D:\SN1.2 C#\PAWN\Language\Lang.ini");
            foreach(Control temp in Controls)
            {
                try
                {
                    temp.Text = data[comboBox2.Text][temp.Tag.ToString()];
                }
                catch(Exception) { }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new GUI.frmDashboard().Show();
            this.Hide();
        }
    }
}
