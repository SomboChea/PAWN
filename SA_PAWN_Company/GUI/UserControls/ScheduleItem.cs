using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class ScheduleItem : UserControl
    {
        public ScheduleItem(string title = "Schedule ID: ")
        {
            InitializeComponent();
            this.lbSchTitle.Text = title;
        }
    }
}