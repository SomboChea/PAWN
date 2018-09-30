using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class InventoryItem : UserControl
    {
        public InventoryItem()
        {
            InitializeComponent();
        }

        private Inventory item = null;
        private int invid;

        public InventoryItem(object data, bool hasWriteOff = false)
        {
            InitializeComponent();

            this.Margin = new Padding(10, 15, 10, 15);

            btnWriteback.Visible = hasWriteOff;
            item = (Inventory)data;
            invid = item.ID;
            lbID.Text += item.ID;
            lbName.Text = item.Name;
            lbType.Text += item.Type;
            lbPrice.Text += "$" + item.Price;
            picBig.ImageLocation = Pawnshop.PATH_PREFIX + "Stuff\\" + item.Image;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "EXEC deleteInventory " + invid;
            if (DataConnection.Connect.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Successful!");
                Dispose();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnWriteback_Click(object sender, EventArgs e)
        {
            int wfid = int.Parse(DataConnection.Connect.ExecuteScalar("SELECT * FROM WriteOff WHERE InvID = " + invid) + "");
            string sql = "EXEC insertWriteBack " + wfid;
            if (DataConnection.Connect.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Successful!");
                Dispose();
            }
        }
    }
}