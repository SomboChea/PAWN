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
    public partial class UserRoleItem : UserControl
    {
        public UserRoleItem()
        {
            InitializeComponent();
        }

        public UserRoleItem(int x)
        {
            InitializeComponent();
            this.Size = new Size(x, 40);
        }
    }
}