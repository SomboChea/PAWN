using DataConnection;
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
    
    public partial class frmAddPos : Form
    {
        public frmAddPos()
        {
            InitializeComponent();
            Connect.Open();
        }

        List<int> optionID = new List<int>(); 

        private void frmAddPos_Load(object sender, EventArgs e)
        {

            DataTable dt = Connect.GetModel("Select * From [Option];");
            foreach (DataRow row in dt.Rows)
            {
                chklist.Items.Add(row[Pawnshop.Langkey == 0 ? "Option_EN" : "Option_KH"]);
                optionID.Add(int.Parse(row["OptionID"].ToString()));
            }

            dgPos.DataSource = Connect.GetModel("Select * from Position");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            chklist.ClearSelected();
            txtname.Enabled = true;
            btnOK.Text = "OK";
        }

        private void dgPos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgPos_Click(object sender, EventArgs e)
        {
            DataTable dt = Connect.GetModel("select r.OptionID from [Option] o left JOIN RoleOption r on r.RoleID=" + dgPos.SelectedRows[0].Cells[0].Value + " and r.OptionID=o.OptionID");
            for (int i = 0; i < dt.Rows.Count; i++)
                chklist.SetItemChecked(i, !dt.Rows[i][0].ToString().Equals(""));
            btnOK.Text = "Update";
            txtname.Enabled = false;
        }

        private bool chklisthaveSelected()
        {
            for (int i = 0; i < chklist.Items.Count; i++)
                if (chklist.GetItemChecked(i))
                    return true;
            return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chklisthaveSelected())
            { return; }
            if (btnOK.Text == "OK")
            {
                string sql = "Insert into Position Value('" + txtname.Text.Trim() + "');Select Scope_identity()";
                int RoleId = int.Parse(Connect.ExecuteScalar(sql) + "");
                for (int i = 0; i < chklist.Items.Count; i++)
                    if (chklist.GetItemChecked(i))
                    {
                        sql = "Insert into RoleOption values('" + RoleId + "','"+optionID[i]+"')";
                        Connect.ExecuteNonQuery(sql);
                    }

                
            }
        }
    }
}