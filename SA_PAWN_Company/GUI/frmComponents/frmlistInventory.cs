using DataConnection;
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
    public partial class frmlistInventory : Form
    {
        public frmlistInventory()
        {
            InitializeComponent();
        }

        public string Code { get; set; }

        private void frmlistInventory_Load(object sender, EventArgs e)
        {
            Connect.Open();
            listView1.LargeImageList = new ImageList();
            listView1.LargeImageList.ImageSize = new Size(listView1.Width * 25 / 100, listView1.Width * 30 / 100);
            comboBox1.SelectedIndex = 0;
            DataTable dt = Connect.GetModel("Select * from viewInventory");

            foreach (ColumnHeader col in listView1.Columns)
                col.Width = listView1.Width / 3;
            listView1.Columns[3].Width = 0;

            foreach (DataRow row in dt.Rows)
            {
                string code = row["SID"] + "";
                string imgpath = Pawnshop.PATH_PREFIX + "Stuff\\" + row["Image"];
                Image img = File.Exists(imgpath) ? Image.FromFile(imgpath) : Properties.Resources.download1;
                listView1.LargeImageList.Images.Add(code, img);
                string[] item = { row["Stuff"].ToString(), row["Type"] + "", double.Parse(row["Price"] + "").ToString("#,##0.00 $"), code };
                ListViewItem list = new ListViewItem(item, listView1.LargeImageList.Images.IndexOfKey(code));
                listView1.Items.Add(list);
            }
        }

        private void frmlistInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult == DialogResult.OK ? DialogResult : DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = comboBox1.SelectedIndex == 0 ? View.Details : View.LargeIcon;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnok.Enabled = listView1.SelectedItems.Count > 0;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Width / 3;
            listView1.Columns[3].Width = 0;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Code = listView1.SelectedItems[0].SubItems[3].Text.ToString();

            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}