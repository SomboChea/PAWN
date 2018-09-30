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
    public partial class Item : UserControl
    {
        public Item(string name, string cate, int qty, double price, int color, string image = null)
        {
            InitializeComponent();

            if (color % 2 == 0)
                panHead.BackColor = Color.DeepPink;
            else
                panHead.BackColor = Color.DeepSkyBlue;

            lbName.Text = name;
            lbCate.Text = "Category: " + cate;
            lbQty.Text = "Quantity: " + qty;
            lbPrice.Text = "Price: $" + price;
            lbAmount.Text = "Total Amount: $" + (qty * price);

            ImageBox.ImageLocation = "http://localhost/SETEC/Web_Final/assets/img/api/" + image;
        }
    }
}