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
    public partial class UCinventory : UserControl
    {
        public UCinventory()
        {
            InitializeComponent();
        }

        private void UCinventory_Load(object sender, EventArgs e)
        {
            DataTable dt = DataConnection.Connect.GetModel("SELECT * FROM viewInventory2 WHERE Status = 1");

            InventoryItem d;
            foreach (DataRow row in dt.Rows)
            {
                Inventory item = new Inventory();
                item.ID = int.Parse(row["INID"] + "");
                item.Name = row["Stuff"] + "";
                item.Type = row["Type"] + "";
                item.Price = double.Parse(row["Price"] + "");
                item.Image = row["Image"] + "";

                if (row["Source"] + "" == "1")
                {
                    d = new InventoryItem(item, true);
                }
                else
                {
                    d = new InventoryItem(item);
                }

                panInventory.Controls.Add(d);
            }
        }
    }
}