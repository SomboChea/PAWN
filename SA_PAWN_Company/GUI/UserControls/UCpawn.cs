using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;
using Helpers;
using DataConnection;

namespace SA_PAWN_Company
{
    public partial class UCPawn : UserControl
    {
        private string image = null;
        private int days = 0;
        private int rate = 0;
        private bool hasSuccess = false;

        public UCPawn()
        {
            InitializeComponent();
            loadStuffType();
            loadDurationType();
            loadIdentityType();
            durationType.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            idType.SelectedIndex = 0;
            stuffType.SelectedIndex = 0;
        }

        private void stuffPicture_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.stuffPicture.Image = Image.FromFile(fd.FileName);
                image = Path.GetFileName(fd.FileName);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtStuffName.Text.Trim() != "" && txtPawnPrice.Text.Trim() != "" && txtDuration.Text.Trim() != "" && txtCustomerName.Text.Trim() != "" && txtTel.Text.Trim() != "")
            {
                panPreview.Controls.Clear();
                int cid = 0, sid = 0, eid = Pawnshop.EmployeeID, pawnid = 0, schid = 0;
                try
                {
                    //Stuff Info
                    string stuffname = txtStuffName.Text;
                    int stufftype = DataConnection.Connect.GetID("SELECT * FROM viewStuffType WHERE Type='" + stuffType.Text + "';");
                    hasSuccess = insertStuff(stuffname, stufftype, ref sid);
                    //if (insertStuff(stuffname, stufftype, ref sid))
                    //{
                    //MessageBox.Show("Stuff Inserted!");

                    //}   //Inserting Stuff

                    //Customer Info
                    string customername = txtCustomerName.Text;
                    string gender = cbGender.Text;
                    string tel = txtTel.Text;
                    Helpers.Text.isNull(tel);
                    int idtypeid = DataConnection.Connect.GetID("SELECT * FROM viewIdentity WHERE IDType = '" + idType.Text + "';");
                    string idnote = txtIDNote.Text;
                    string address = txtAddress.Text;
                    hasSuccess = insertCustomer(customername, gender, tel, idtypeid, idnote, address, ref cid);
                    //if (insertCustomer(customername, gender, tel, idtypeid, idnote, address, ref cid))
                    //{
                    //MessageBox.Show("Customer Inserted!");
                    //}   //Inserting Customer

                    //Pawn Info
                    double pawnprice = float.Parse(txtPawnPrice.Text);
                    int duration = int.Parse(txtDuration.Text);
                    int interestrate = rate;
                    int idtype = DataConnection.Connect.GetID("SELECT * FROM viewDuration WHERE Type = '" + durationType.Text + "';");
                    int paycount = int.Parse(txtPaycount.Text);
                    string file = txtAttachement.Text;
                    hasSuccess = insertPawn(cid, eid, sid, pawnprice, duration, interestrate, file, idtype, ref pawnid);
                    //if (insertPawn(cid, eid, sid, pawnprice, duration, interestrate, file, idtype, ref pawnid))
                    //{
                    //MessageBox.Show("Pawn Inserted!");
                    //}   //Insert Pawn

                    //Start Transactions
                    hasSuccess = insertSchedule(pawnid, paycount, ref schid);
                    //if (insertSchedule(pawnid, paycount, ref schid))
                    //{
                    //MessageBox.Show("Schedule Inserted");
                    //}

                    hasSuccess = generateSchedule(schid, interestrate, pawnprice, paycount);

                    if (hasSuccess)
                    {
                        btnReset_Click(null, null);
                        MessageBox.Show("Successfully generated!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to generating!");
                    }
                }
                catch (Exception) { hasSuccess = false; return; }
            }
            else
            {
                MessageBox.Show("Please complete all required fields!");
            }
        }

        /** Insert Stuff **/

        private bool insertStuff(string name, int type, ref int stuffID)
        {
            string sql = "INSERT INTO Stuff(Stuff,STID, Image) VALUES('" + name + "'," + type + ",'" + image + "');";
            if (!name.Equals("") && !type.Equals(0) && DataConnection.Connect.ExecuteNonQuery(sql))
            {
                stuffID = int.Parse(DataConnection.Connect.ExecuteScalar("SELECT MAX(SID) FROM Stuff;") + "");
                return true;
            }
            return false;
        }

        /** Insert Customer **/

        private bool insertCustomer(string name, string gender, string tel, int idtype, string idnote, string address, ref int custID)
        {
            string sql = "INSERT INTO Customer(name, gender, tel, idtypeid, idnote, address) VALUES('" + name + "','" + gender + "','" + tel + "'," + idtype + ",'" + idnote + "','" + address + "');";
            if (!name.Equals("") && !tel.Equals("") && DataConnection.Connect.ExecuteNonQuery(sql))
            {
                custID = int.Parse(DataConnection.Connect.ExecuteScalar("SELECT MAX(CID) FROM Customer;") + "");
                return true;
            }
            return false;
        }

        /** Insert Pawn **/

        private bool insertPawn(int cid, int eid, int sid, double price, int duration, int rate, string file, int dtype, ref int pawnID)
        {
            string date = DateTime.Today.ToShortDateString();
            string sql = "INSERT INTO PawnContract([date], cid, eid, sid, pawnprice, duration, interestrate, attachement, [Status], DIDT) VALUES('" + date + "'," + cid + "," + eid + "," + sid + "," + price + "," + duration + "," + rate + ",'" + file + "',1," + dtype + ");";
            if (DataConnection.Connect.ExecuteNonQuery(sql))
            {
                pawnID = int.Parse(DataConnection.Connect.ExecuteScalar("SELECT MAX(PawnID) FROM PawnContract;") + "");
                return true;
            }
            return false;
        }

        /** Insert Schedule **/

        private bool insertSchedule(int pawnid, int paycount, ref int schID)
        {
            string sql = "INSERT INTO Schedule(pawnid, [status], paycount) VALUES(" + pawnid + ",1," + paycount + ");";
            if (DataConnection.Connect.ExecuteNonQuery(sql))
            {
                schID = int.Parse(DataConnection.Connect.ExecuteScalar("SELECT MAX(SCHID) FROM Schedule;") + "");
                return true;
            }
            return false;
        }

        /** Insert and Generating Schedule **/

        private bool generateSchedule(int schid, int interestrate, double pawnprice, int paycount)
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
                ed = st.AddDays(part_days + plus_days);
                plus_days = 0;

                plus = Duration.GetLastDayHoliday(ed.AddDays(-1));
                ed = ed.AddDays(plus);
                paydate = ed.AddDays(-1).ToShortDateString(); // Get pay date
                pay_days = int.Parse((ed - st).TotalDays + ""); // Get number days for pay

                /** Settings here for Schedules List **/
                title = (c + 1) + "";

                amountpay = Math.Round(pay_a_day * pay_days, 2);
                interest = Math.Round(amountpay * (rate / 100), 2);
                totalpay = Math.Round(amountpay + interest, 2);

                //paydate, rate, amountpay, interest, payday, punish, totalpay, title, payRnot = false
                items[c] = new ScheduleItem(paydate, rate + "", amountpay + "", interest + "", pay_days + "", punishement + "", totalpay + "", title, c + 1);
                panPreview.Controls.Add(items[c]);

                string sql = "INSERT INTO ScheduleDetail(schid, amountleft, interestrate, interest, amountpay, paydate, paystatus, payday) ";
                sql += "VALUES(" + schid + "," + amountleft + "," + rate + "," + interest + "," + amountpay + ",'" + paydate + "',0, " + pay_days + ");";

                DataConnection.Connect.ExecuteNonQuery(sql);

                /** END **/
                part_days -= plus;
                st = ed;
                c++;
            }
            /** End Generating **/

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
            frminputbox inputbox = new frminputbox();
            inputbox.Text = "Add Stuff Type";
            inputbox.lbparam.Text = "Stuff Type Name :";
            if (inputbox.ShowDialog() == DialogResult.OK)
            {
                Connect.ExecuteNonQuery("Insert Into StuffType Values('" + inputbox.Value + "',1)");
                Helper.FillCombobox(stuffType, "Type", "STID", "Select * from StuffType");
            }
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

        /** Load Identity Type **/

        private void loadIdentityType()
        {
            DataTable dt = DataConnection.Connect.GetModel("SELECT * FROM viewIdentity;");
            foreach (DataRow row in dt.Rows)
                idType.Items.Add(row["IDType"]);
        }

        private void durationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDays();
        }

        private int getDays()
        {
            int idx = durationType.SelectedIndex;
            int dur = 0;
            int.TryParse(txtDuration.Text, out dur);
            days = Duration.InDays(dur, idx);
            rate = getRate(days);
            return days;
        }

        private int getRate(int days)
        {
            int rex = 0;
            if (txtDuration.Text.Trim() != "" && txtDuration.Text != null && txtDuration.Text != "0" && days != 0)
            {
                int.TryParse(DataConnection.Connect.ExecuteScalar("EXEC getRate " + days) + "", out rex);
                txtRate.Text = rex + "%";
            }
            else
            {
                txtRate.Text = rex + "%";
            }

            return rex;
        }

        private void UCPawn_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter");
            }
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            if (txtDuration.Text != null && txtDuration.Text.Trim() != "")
            {
                durationType.Enabled = true;
                durationType.SelectedIndex = durationType.SelectedIndex;
                getDays();
            }
            else
            {
                durationType.Enabled = false;
                txtRate.Text = "0%";
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.Text.IsDigit(e);
        }

        private void txtPaycount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.Text.IsDigit(e);
        }

        private void txtPawnPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.Text.IsDecimal(e);
        }

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.Text.IsDigit(e);
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.Text.IsDecimal(e);
        }

        private bool rateEdit = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtRate.ReadOnly = rateEdit;
            if (!rateEdit)
            {
                txtRate.Text = txtRate.Text.TrimEnd('%');
                btnEdit.Text = "C";
                rateEdit = true;
            }
            else
            {
                int r = 0;
                int.TryParse(txtRate.Text.TrimEnd('%'), out r);
                rate = r;
                txtRate.Text = rate + "%";
                btnEdit.Text = "E";
                rateEdit = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStuffName.Clear();
            txtPawnPrice.Clear();
            txtDuration.Clear();
            txtRate.Clear();
            txtAttachement.Clear();
            txtCustomerName.Clear();
            txtTel.Clear();
            txtIDNote.Clear();
            txtAddress.Clear();
        }
    }
}