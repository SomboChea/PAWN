using System;
using System.Drawing;
using System.Windows.Forms;

namespace Helper
{
    public static class Helper
    {
        public static bool StartsWithUpper(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            Char ch = str[0];
            return Char.IsUpper(ch);
        }

        private void dsf(Control control)
        {
            control.Size = new Size(3, 3);
        }
    }
}
