using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class PopupBox : Form
    {
        public PopupBox()
        {
            InitializeComponent();
            FullMode.PopUp(this);
        }

        public PopupBox(UserControl uc)
        {
            InitializeComponent();
            this.Size = new Size(uc.Size.Width, uc.Size.Height + 50);
            panTwo.Visible = false;
            uc.Dock = DockStyle.Fill;
            panOne.Controls.Add(uc);
            FullMode.PopUp(this);
        }

        public PopupBox(UserControl uc, bool next, bool prev = false)
        {
            InitializeComponent();
            btnPrev.Visible = prev;
            btnNext.Visible = next;
            this.Size = new Size(uc.Size.Width, (uc.Size.Height + panTwo.Size.Height + 50));
            panOne.Size = new Size(uc.Size.Width, uc.Size.Height);
            panTwo.Size = new Size(uc.Size.Width, panTwo.Size.Height);
            uc.Dock = DockStyle.Fill;
            panOne.Controls.Add(uc);
            FullMode.PopUp(this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
        }
    }
}