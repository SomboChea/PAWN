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

        public ScheduleItem(string paydate, string rate, string amountpay, string interest, string payday, string punish, string totalpay, string title, bool payRnot = false, bool payable = false)
        {
            this.payable = payable;
            InitializeComponent();
            lbSchTitle.Text += title;
            lbPaydate.Text += paydate;
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
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (payable)
            {
                int PayState = 1;
                if (btnPay.Enabled)
                {
                    PayState = 0;
                    btnPay.Enabled = false;
                    btnPay.Text = "Paid";
                }
                string sql = "UPDATE ScheduleDetail SET PayStatus =  " + PayState + ";";
                bool checkPay = DataConnection.Connect.ExecuteNonQuery(sql);
                if (!checkPay)
                    btnPay.Enabled = true;
                else
                    MessageBox.Show("Paid successfully!");
            }
        }
    }
}