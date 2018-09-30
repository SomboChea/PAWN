using System;
using System.Drawing;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class StuffItem : UserControl
    {
        private int pawnid;

        public StuffItem(int pawnid, string name, string date, string expdate, double price, string duration, int interest, string emp, string custel, double totalinterest, double punish = 0, string image_path = null)
        {
            InitializeComponent();
            this.Margin = new Padding(15, 15, 15, 0);
            this.pawnid = pawnid;
            lbID.Text += pawnid;
            lbName.Text = name;
            lbDate.Text += date;
            lbExpDate.Text += expdate;
            lbPawnPrice.Text += price;
            lbDuration.Text += duration;
            lbRate.Text += interest + "%";
            lbEmp.Text += emp;
            lbCust.Text += custel;
            lbInterest.Text += totalinterest;
            lbAmount.Text += (price + totalinterest + punish);
            lbPunish.Text += punish;
            if (image_path != null)
                stuffPhoto.ImageLocation = Pawnshop.PATH_PREFIX + "Stuff\\" + image_path;

            DateTime curDateTime = DateTime.Today;
            DateTime expDateTime = DateTime.Parse(expdate);
            if (curDateTime > expDateTime)
            {
                btnWriteOff.Visible = true;
                panHead.BackColor = Color.Crimson;
                int otimes = (curDateTime - expDateTime).Days;
                lbOvertime.Text += otimes;
                lbOvertime.Visible = true;
            }

            if (!lbOvertime.Visible)
                lbAmount.Location = lbOvertime.Location;
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            string sql = "EXEC insertWriteOff " + pawnid;
            float price = 0;
            frminputbox p = new frminputbox(true);
            //Overlay vl = new Overlay();
            //vl.Show();

            p.lbparam.Text = "Enter a Price for Sale";
            if (p.ShowDialog() == DialogResult.OK)
                price = float.Parse(p.Value);

            if (price > 0 && DataConnection.Connect.ExecuteNonQuery(sql))
            {
                sql = "UPDATE Inventory SET Price = " + price + "WHERE INID = (SELECT MAX(INID) FROM Inventory);";
                if (DataConnection.Connect.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Write Off Successful!");
                    Dispose();
                }
                return;
            }
            else
                MessageBox.Show("Failed to write off!");

            //vl.Close();
        }
    }
}