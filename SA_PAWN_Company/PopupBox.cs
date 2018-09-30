using Helpers;
using System.Drawing;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class PopupBox : Form
    {
        public PopupBox()
        {
            InitializeComponent();
            //FullMode.PopUp(this);
        }

        public PopupBox(UserControl uc)
        {
            InitializeComponent();
            this.Size = new Size(uc.Size.Width, uc.Size.Height + 50);
            uc.Dock = DockStyle.Fill;
            panOne.Controls.Add(uc);
            //FullMode.PopUp(this);
        }

        private void panOne_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.Hide();
        }
    }
}