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
using MetroFramework.Controls;

namespace SA_PAWN_Company.GUI
{
    public partial class UCbuy : UserControl
    {
        Control[] requirement;
        public UCbuy()
        {
            InitializeComponent();
            Control[] ct = { txtname, txtcost, txtprice, cbtype };
            requirement = ct;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image PNG (*.png)|*.png|Image JPG (*.jpg)|*.png";
            opf.Title = "Browse Product Image ...";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string imgpath = Helper.Upload_Photo(opf.FileName, Pawnshop.PATH_PREFIX + "Stuff\\");
                pictureBox1.Image = imgpath==""?Properties.Resources.download1:Image.FromFile(imgpath);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckRequirement(groupBox1, requirement))
            {
                return;
            }
            if (!Helper.CheckDouble(groupBox1, txtprice,txtcost))
            {
                return;
            }
           
                
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            foreach(Control ctrl in groupBox1.Controls)
            {
                if (ctrl is MetroTextBox)
                    ((MetroTextBox)ctrl).Text = "";
                else if (ctrl is MetroComboBox)
                {
                    try
                    {
                        ((MetroComboBox)ctrl).SelectedIndex = 0;
                    }
                    catch (Exception) { }
                }
                pictureBox1.Image = Properties.Resources.download1;
            }
        }
    }
}
