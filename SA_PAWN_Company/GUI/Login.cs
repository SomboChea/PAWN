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
            string jsontext = File.ReadAllText(@"D:\SN1.2 C#\PAWN\Lang.json");
            string jsonsplit = jsontext.Split(',')[3]+ jsontext.Split(',')[4];
            string jsonfinal = jsonsplit.Substring(1, jsonsplit.Length - 2);
            JObject json = JObject.Parse(jsonfinal);
            //JArray jsonrow = new JArray(jsontext);
            //JObject json=new JObject();
            //int id = 0;
            //foreach(JObject temp in jsonrow.Children<JObject>())
            //{
            //    if (id == comboBox1.SelectedIndex)
            //        json = temp;
            //    id++;
            //}
            //label1.Text =id+"";
            //JObject json = JObject.Parse(jsonrow[0].ToString());
           // JObject json = new JObject(jsontext);
            //JObject json = JObject.Parse("{Username:\"ឈ្មោះ\",Password:\"លេខសម្ងាត់\"}");
            //JObject json = JObject.Parse(jsonrow[0].ToString());
            foreach (Control ctrl in Controls)
            {
                try
                {
                    if (json[ctrl.Tag].ToString() != "")
                    {
                        ctrl.Text = json[ctrl.Tag].ToString();
                    }
                }
                catch (Exception) { }
            }
            //metroLabel1.Text = File.ReadAllText(@"D:\SN1.2 C#\PAWN\Lang.json");
        }
    }
}
