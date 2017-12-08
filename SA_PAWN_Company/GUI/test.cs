using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SA_PAWN_Company.GUI
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Log.Write("This is a log file");
            MessageBox.Show(getMsg());
        }

        [DllImport("Helpers", CharSet = CharSet.Unicode)]
        private static extern string Read(string path);

        private string getMsg()
        {
            return Read("log.txt");
        }
    }
}