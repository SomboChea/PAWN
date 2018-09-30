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
using DataConnection;

namespace SA_PAWN_Company
{
    public partial class blockEmployee : UserControl
    {
        public blockEmployee()
        {
            InitializeComponent();
        }
        public string id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string salary { get; set; }
        public string position{get; set; }
        public string imgname { get; set; }

        private void UCemployee2_Load(object sender, EventArgs e)
        {
            lbid.Text += id;
            lbname.Text = name;
            lbposition.Text += position;
            lbSalary.Text += salary;
            lbgender.Text += gender;

            btndel.Tag = id;
            btnEdit.Tag = id;

            string imgpath = Pawnshop.PATH_PREFIX + "Employee\\" + imgname;
            pictureBox1.Image = File.Exists(imgpath) ? Image.FromFile(imgpath) : Properties.Resources.Simpleicons_Interface_business_man_1_svg;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Open Form Edit
        }

        private void btndel_Click(object sender, EventArgs e)
        {
          

        }
    }
}
