using System;
using System.Drawing;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class RoleItem : UserControl
    {
        private bool chk = true;

        public bool IsCheck { get; set; }
        public string Title { get; set; }

        public RoleItem()
        {
            InitializeComponent();
        }

        public RoleItem(string title, string image, bool chk = false)
        {
            InitializeComponent();
            iconBig.ImageLocation = image;
            Nono.Text = title;
            Title = title;
            this.chk = chk;
            IsCheck = chk;
            panMain_Click(null, null);
        }

        private void panMain_Click(object sender, EventArgs e)
        {
            checkBox.Checked = chk;
            IsCheck = chk;
            Nono.Enabled = chk;
            chk = !checkBox.Checked;
        }

        private void checkBox_OnChange(object sender, EventArgs e)
        {
            panMain_Click(sender, e);
        }
    }
}