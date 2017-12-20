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
            generateSchedule(0, 0, 0, days, paycount);
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
            float amountleft = 0;
            int rate = 0;
            float interest = 0;
            float amountpay = 0;
            string paydate = null;

            /** Generating **/
            DateTime st = DateTime.Today;
            DateTime ed;
            int c = 0;
            int part_days = days / paycount;
            int still_days = part_days;
            int pay_days = 0;
            int plus_days = days % paycount;
            int plus = 0;
            while (c < paycount)
            {
                ed = st.AddDays(part_days);
                plus = Duration.GetLastDayHoliday(ed.AddDays(-1));
                if (part_days >= still_days)
                    ed = ed.AddDays(plus);
                else
                    ed = ed.AddDays(plus + plus_days);
                //MessageBox.Show(st.ToShortDateString() + "\n" + ed.AddDays(-1).ToShortDateString());
                paydate = ed.AddDays(-1).ToShortDateString(); // Get pay date
                pay_days = int.Parse((ed - st).TotalDays + ""); // Get number days for pay
                MessageBox.Show("Pay date at: " + paydate + "\n" + "Amount days: " + pay_days);
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
    }
}