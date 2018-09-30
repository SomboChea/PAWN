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
    public partial class FindStuff : Form
    {
        public FindStuff()
        {
            InitializeComponent();

            DataConnection.Connect.Open();

            string sql = "SELECT * FROM viewActiveStuff";
            DataTable dt = DataConnection.Connect.GetModel(sql);
            foreach (DataRow row in dt.Rows)
            {
                string[] r = { row["SID"] + "", row["Stuff"] + "", row["Type"] + "" };
                ListViewItem item = new ListViewItem(r);
                listStuff.Items.Add(item);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listStuff.SelectedItems[0].Text);
        }
    }
}