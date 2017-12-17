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
            string stuffname = txtStuffName.Text;
            string stufftype = stuffType.Text;

            float pawnprice = float.Parse(txtPawnPrice.Text);
            int duration = int.Parse(durationType.Text);
            float interestrate = float.Parse(txtRate.Text);
            int paycount = int.Parse(txtPaycount.Text);
            string file = txtAttachement.Text;

            string customername = txtCustomerName.Text;
            string gender = cbGender.Text;
            string tel = txtTel.Text;
            int idtype = int.Parse(idType.Text);
            string address = txtAddress.Text;
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
    }
}