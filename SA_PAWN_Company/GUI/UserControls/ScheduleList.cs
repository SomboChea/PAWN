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
    public partial class ScheduleList : UserControl
    {
        public ScheduleList()
        {
            InitializeComponent();
            loadItems(15);
            itemBox.AutoScroll = true;
        }

        private void loadItems(int n)
        {
            ScheduleItem[] items = new ScheduleItem[n];
            for (int i = 0; i < n; i++)
            {
                items[i] = new ScheduleItem("Schedule ID: " + i);
                itemBox.Controls.Add(items[i]);
            }
        }
    }
}