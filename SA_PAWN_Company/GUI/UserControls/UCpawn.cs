using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Helpers;

namespace SA_PAWN_Company
{
    public partial class UCPawn : UserControl
    {
        private string image = null;

        public UCPawn()
        {
            InitializeComponent();
            loadStuffType();
            loadDurationType();
        }

        private void stuffPicture_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.stuffPicture.Image = Image.FromFile(fd.FileName);
                image = Path.GetFullPath(fd.FileName);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int paycount = int.Parse(txtPaycount.Text);
            panPreview.Controls.Clear();
            int rate = int.Parse(txtRate.Text);
            float price = float.Parse(txtPawnPrice.Text);
            generateSchedule(0, rate, price, days, paycount);
            //try
            //{
            //    //Stuff Info
            //    string stuffname = txtStuffName.Text;
            //    int stufftype = DataConnection.Connect.GetID("SELECT * FROM viewStuffType WHERE Type='" + stuffType.Text + "';");

            //    //Pawn Info
            //    float pawnprice = float.Parse(txtPawnPrice.Text);
            //    int duration = int.Parse(durationType.Text);
            //    float interestrate = float.Parse(txtRate.Text);
            //    int paycount = int.Parse(txtPaycount.Text);
            //    string file = txtAttachement.Text;

            //    //Customer Info
            //    string customername = txtCustomerName.Text;
            //    string gender = cbGender.Text;
            //    string tel = txtTel.Text;
            //    int idtype = DataConnection.Connect.GetID("SELECT * FROM viewDuration WHERE Type = '" + durationType.Text + "';");
            //    string address = txtAddress.Text;

            //    //Start Transactions
            //}
            //catch (Exception) { return; }
        }

        /** Insert Stuff **/

        private bool insertStuff(string name, int type)
        {
            string sql = "INSERT INTO Stuff(Stuff,STID, Image) VALUES('" + name + "'," + type + ",'" + image + "');";
            if (DataConnection.Connect.ExecuteNonQuery(sql))
                return true;
            return false;
        }

        /** Insert Pawn **/

        private bool insertPawn(int cid, int eid, int sid, float price, int duration, int rate, string file, int dtype)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy hh:m:ss");
            string sql = "INSERT INTO PawnContract(date, cid, eid, sid, pawnprice, duration, interestrate, attachement, DIDT) VALUES('" + date + "'," + cid + "," + eid + "," + sid + "," + price + "," + duration + "," + rate + ",'" + file + "'," + dtype + ");";
            if (DataConnection.Connect.ExecuteNonQuery(sql))
                return true;
            return false;
        }

        /** Insert Schedule **/

        private bool insertSchedule(int pawnid, int paycount)
        {
            string sql = "INSERT INTO Schedule(pawnid, paycount) VALUES(" + pawnid + "," + paycount + ");";
            if (DataConnection.Connect.ExecuteNonQuery(sql))
                return true;
            return false;
        }

        /** Insert and Generating Schedule **/

        private bool generateSchedule(int schid, int interestrate, float pawnprice, int duration, int paycount)
        {
            double amountleft = pawnprice;
            double pay_a_day = 0;
            float rate = interestrate;
            double interest = 0;
            double amountpay = 0;
            string paydate = null;

            /** Generating **/
            DateTime st = DateTime.Today;
            DateTime ed;

            int c = 0;
            int part_days = days / paycount;
            int pay_days = 0;
            int plus_days = days % paycount;
            int plus = 0;
            string title;
            float punishement = 0;
            double totalpay = 0;
            pay_a_day = Math.Round(pawnprice / days, 2);

            ScheduleItem[] items = new ScheduleItem[paycount];
            while (c < paycount)
            {
                if (plus_days > 0)
                {
                    plus_days -= 1;
                    ed = st.AddDays(part_days + 1);
                }
                else
                {
                    ed = st.AddDays(part_days);
                }

                plus = Duration.GetLastDayHoliday(ed.AddDays(-1));
                ed = ed.AddDays(plus);
                paydate = ed.AddDays(-1).ToShortDateString(); // Get pay date
                pay_days = int.Parse((ed - st).TotalDays + ""); // Get number days for pay

                //MessageBox.Show("Pay date at: " + paydate + "\n" + "Amount days: " + pay_days);
                /** Settings here for Schedules List **/
                title = (c + 1) + "";

                amountpay = Math.Round(pay_a_day * pay_days, 2);
                interest = Math.Round(amountpay * (rate / 100), 2);
                totalpay = Math.Round(amountpay + interest, 2);

                //paydate, rate, amountpay, interest, payday, punish, totalpay, title, payRnot = false
                items[c] = new ScheduleItem(paydate, rate + "", amountpay + "", interest + "", pay_days + "", punishement + "", totalpay + "", title);
                panPreview.Controls.Add(items[c]);

                /** END **/
                part_days -= plus;
                st = ed;
                c++;
            }
            /** End Generating **/

            string sql = "INSERT INTO ScheduleDetail(schid, amountleft, interestrate, interest, amountpay, paydate, paystatus) ";
            sql += "VALUES(" + schid + "," + amountleft + "," + rate + "," + interest + "," + amountpay + ",'" + paydate + "',0);";
            return false;
        }

        /** Browe for Attachement **/

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtAttachement.Text = Path.GetFileName(fd.FileName);
            }
        }

        /** Add Stuff Type **/

        private void btnStuffType_Click(object sender, EventArgs e)
        {
            App.Open(new StuffType());
        }

        /** Load Stuff Type **/

        private void loadStuffType()
        {
            DataTable dt = DataConnection.Connect.GetModel("SELECT * FROM viewStuffType;");
            foreach (DataRow row in dt.Rows)
                stuffType.Items.Add(row["Type"]);
        }

        /** Load Duration Type **/

        private void loadDurationType()
        {
            DataTable dt = DataConnection.Connect.GetModel("SELECT * FROM viewDuration;");
            foreach (DataRow row in dt.Rows)
                durationType.Items.Add(row["Type"]);
        }

        private int days = 0;

        private void durationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = durationType.SelectedIndex;
            days = Duration.InDays(int.Parse(txtDuration.Text), idx);
        }

        private void panPreview_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}