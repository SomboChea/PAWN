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
    public partial class ScheduleItem : UserControl
    {
        private bool payable = false;
        private string paydate = null;

        public ScheduleItem(string paydate, string rate, string amountpay, string interest, string payday, string punish, string totalpay, string title, int color = 0, bool payRnot = false, bool payable = false)
        {
            this.payable = payable;
            this.paydate = paydate;
            InitializeComponent();
            lbSchTitle.Text += title;
            lbPaydate.Text += DateTime.Parse(paydate).ToShortDateString();
            lbRate.Text += rate + "%";
            lbAmount.Text += "$" + amountpay;
            lbInterest.Text += "$" + interest;
            lbAmountDays.Text += payday;
            lbPunish.Text += "$" + punish;
            lbTotalPay.Text += "$" + totalpay;
            if (payRnot)
            {
                btnPay.Text = "Paid";
                btnPay.Enabled = false;
            }
            else
            {
                btnPay.Text = "Pay";
                btnPay.Enabled = true;
            }

            if (color % 2 == 0)
                bunifuCards1.color = Color.DeepPink;
            else
                bunifuCards1.color = Color.DodgerBlue;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (payable)
            {
                int PayState = 0;
                if (btnPay.Enabled)
                {
                    PayState = 1;
                    btnPay.Enabled = false;
                    btnPay.Text = "Paid";
                }
                string sql = "UPDATE ScheduleDetail SET PayStatus =  " + PayState + " WHERE PayDate = '" + paydate + "';";
                bool checkPay = DataConnection.Connect.ExecuteNonQuery(sql);
                if (!checkPay)
                    btnPay.Enabled = true;
                else
                    MessageBox.Show("Paid successfully!");
            }
        }
    }
}