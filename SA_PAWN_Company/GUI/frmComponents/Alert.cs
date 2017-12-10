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
    public partial class Alert : Form
    {
        private string _msg;
        private string _btnOK;
        private string _btnCancel;

        public static Color CardColor
        {
            get { return Color.DeepPink; }
            set { CardColor = value; }
        }

        public Alert()
        {
            InitializeComponent();
            FullMode.PopUp(this);
        }

        public Alert(string message, string title = "Alert")
        {
            InitializeComponent();
            FullMode.PopUp(this);

            lbTitle.Text = title;
            lbMsg.Text = message;
            cardBox.color = CardColor;
        }
    }
}