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
    public partial class ScheduleList : UserControl
    {
        public ScheduleList()
        {
            InitializeComponent();
            loadItems(15);
            itemBox.AutoScroll = true;
        }

        private void loadFilter(int pawnid)
        {
            itemBox.Controls.Clear();
            lbCustID.Text = "Customer Tel: Unified";
            string sql = "SELECT * FROM viewScheDetail WHERE PawnID = " + pawnid + " AND PawnStatus = 1;";
            DataTable dt = DataConnection.Connect.GetModel(sql);
            ScheduleItem[] items = new ScheduleItem[dt.Rows.Count];
            bool payRnot = false;
            int c = 0;
            foreach (DataRow row in dt.Rows)
            {
                lbCustID.Text = "Customer Tel: " + row["Tel"];
                payRnot = Convert.ToBoolean(row["PayStatus"]);
                //string paydate, string rate, string amountpay, string interest, string payday, string punish, string totalpay, string title
                items[c] = new ScheduleItem(row["PayDate"] + "", row["Rate"] + "", row["AmountPay"] + "", row["Interest"] + "", row["PayDay"] + "", 0 + "", row["TotalPay"] + "", (c + 1) + "", (c + 1), payRnot, true);
                itemBox.Controls.Add(items[c]);
                c++;
            }
        }

        private void loadItems(int n)
        {
            string sql = "SELECT * FROM ";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int pawnid = 0;
            try
            {
                pawnid = int.Parse(txtSearch.Text);
            }
            catch (Exception)
            {
                pawnid = 0;
            }

            loadFilter(pawnid);
        }
    }
}