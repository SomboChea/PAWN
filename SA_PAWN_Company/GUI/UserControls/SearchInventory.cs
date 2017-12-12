using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;

namespace SA_PAWN_Company
{
    public partial class SearchInventory : Form
    {
        public SearchInventory()
        {
            InitializeComponent();
            FullMode.PopUp(this);
        }
    }
}