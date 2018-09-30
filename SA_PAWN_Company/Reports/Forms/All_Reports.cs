using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_PAWN_Company.Reports.Forms
{
    public partial class All_Reports : UserControl
    {
        public All_Reports()
        {
            InitializeComponent();

            DataConnection.Connect.Open();

            Helpers.Helper.FillDatagridview(dataView, "SELECT * FROM [Employee]");
        }
    }
}