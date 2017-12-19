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
                MessageBox.Show(Path.GetFullPath(fd.FileName));
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                //Stuff Info
                string stuffname = txtStuffName.Text;
                int stufftype = DataConnection.Connect.GetID("SELECT * FROM viewStuffType WHERE Type='" + stuffType.Text + "';");

                //Pawn Info
                float pawnprice = float.Parse(txtPawnPrice.Text);
                int duration = int.Parse(durationType.Text);
                float interestrate = float.Parse(txtRate.Text);
                int paycount = int.Parse(txtPaycount.Text);
                string file = txtAttachement.Text;

                //Customer Info
                string customername = txtCustomerName.Text;
                string gender = cbGender.Text;
                string tel = txtTel.Text;
                int idtype = DataConnection.Connect.GetID("SELECT * FROM viewDuration WHERE Type = '" + durationType.Text + "';");
                string address = txtAddress.Text;
            }
            catch (Exception) { return; }
        }

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
    }
}