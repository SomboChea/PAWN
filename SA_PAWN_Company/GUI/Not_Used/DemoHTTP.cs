using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class DemoHTTP : Form
    {
        private string url = "http://localhost/SETEC/Web_Final/products/api/products";
        private List<ST_DATA> list = new List<ST_DATA>();
        private System.Net.WebClient client = new System.Net.WebClient();

        public DemoHTTP()
        {
            InitializeComponent();
        }

        private void DemoHTTP_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load(string arg = null)
        {
            try
            {
                var data = client.DownloadString(url + arg);
                JArray jArray = JArray.Parse(data);

                if (jArray.Count <= 0)
                {
                    itemBox.Controls.Add(lb404);
                    lb404.Visible = true;
                }
                else
                    lb404.Visible = false;

                foreach (JObject temp in jArray.Children())
                {
                    ST_DATA d = new ST_DATA();
                    d.pid = int.Parse(temp.Property("pid").Value + "");
                    d.pname = temp.Property("pname").Value + "";
                    d.cname = temp.Property("cname").Value + "";
                    d.qty = int.Parse(temp.Property("qty").Value + "");
                    d.price = double.Parse(temp.Property("price").Value + "");
                    d.image = temp.Property("image").Value + "";
                    list.Add(d);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            itemBox.AutoScroll = true;
            Item[] item = new Item[list.Count];
            int i = 0;
            foreach (ST_DATA temp in list)
            {
                item[i] = new Item(temp.pname, temp.cname, temp.qty, temp.price, i,temp.image);
                item[i].Margin = new Padding(5, 10, 5, 10);

                itemBox.Controls.Add(item[i]);
                i++;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            itemBox.Controls.Clear();
            list.Clear();
            load();
        }

        private bool searchOpen = true;
        private bool cbOpen = false;

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = searchOpen ? true : false;
            searchOpen = !searchOpen;
            cbShowby.Visible = cbOpen ? true : false;
            cbOpen = !cbOpen;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            itemBox.Controls.Clear();
            list.Clear();
            if (txtSearch.Text.Trim() != "")
                load("/search/" + txtSearch.Text);
            else
                load();
        }

        private void cbShowby_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemBox.Controls.Clear();
            list.Clear();
            if (cbShowby.Text.Trim() != "")
                load("/category/" + cbShowby.Text);
            else
                load();
        }
    }

    public class ST_DATA
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public string cname { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
        public string image { get; set; }
    }
}