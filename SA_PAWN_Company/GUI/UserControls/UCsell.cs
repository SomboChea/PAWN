using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Helpers;
using DataConnection;
using System.IO;

namespace SA_PAWN_Company.GUI
{
    public partial class UCsell : UserControl
    {
        Control[] requirement { get; set; }
        public UCsell()
        {
            InitializeComponent();
            Control[] c = { cbinventoryname, cbinventype };
            requirement = c;

            Helper.FillCombobox(cbinventype, "Type", "STID", "Select * from StuffType Where Status=1;");
            clear(this);

            
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

        private object clear(Control mains)
        {
            foreach (Control main in mains.Controls)
            {
                if (main is BunifuCards)
                    return clear(main);
                if (main is BunifuMetroTextbox)
                    main.Text = "";
                if (main is ComboBox)
                    ((ComboBox)main).SelectedIndex = 0;

            }
            foreach (ListViewItem list in listView1.Items)
                listView1.Items.Remove(list);

            return null;
        }


        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            clear(this);
        }

        private void cblisttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = cblisttype.SelectedIndex == 0 ? View.Details : View.LargeIcon;
        }

        private void cbinventoryname_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtprice.Text = double.Parse( Connect.ExecuteScalar("Select Price from viewInventory Where SID=" + cbinventoryname.SelectedValue) + "").ToString("#,##0.00 $");
            //string imgname= Connect.ExecuteScalar("Select Photo from viewInventory Where SID=" + cbinventoryname.SelectedValue) + "";
            //pictureBox1.Image = File.Exists( Pawnshop.PATH_PREFIX+ imgname) ? Image.FromFile(Pawnshop.PATH_PREFIX + imgname) : Properties.Resources.download1;
        }

        private void cbinventype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helper.FillCombobox(cbinventoryname, "Stuff", "SID", "Select * from viewInventory Where STID=" + cbinventype.SelectedValue);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] item = {cbinventype.Text,cbinventoryname.Text,txtprice.Text };
            ListViewItem listitem = new ListViewItem(item);
            listView1.Items.Add(listitem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem row = listView1.SelectedItems[0];
                cbinventype.SelectedItem = row.SubItems[0];
                cbinventoryname.SelectedItem = row.SubItems[1];
                txtprice.Text = row.SubItems[2]+"";
            }
        }
    }
}
