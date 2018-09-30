using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    public partial class UCStuff : UserControl
    {
        public UCStuff(string searchString = null, string searchKey = "Stuff")
        {
            InitializeComponent();
            panStuffItems.AutoScroll = true;
            string sql = "SELECT* FROM viewStuffPawned2";
            if (searchString != null && searchKey != null)
                sql += " WHERE " + searchKey + " LIKE '%" + searchString + "%' AND Status = 1";
            else
                sql = "SELECT* FROM viewStuffPawned2 WHERE Status = 1";

            var dt = DataConnection.Connect.GetModel(sql);
            //List<StuffItem> items = new List<StuffItem>();
            StuffItem item;
            foreach (DataRow row in dt.Rows)
            {
                item = new StuffItem(int.Parse(row["PawnID"] + ""), row["Stuff"] + "", DateTime.Parse(row["PawnDate"] + "").ToShortDateString(), DateTime.Parse(row["ExpDate"] + "").ToShortDateString(), double.Parse(row["PawnPrice"] + ""), row["Duration"] + "", int.Parse(row["InterestRate"] + ""), row["EmpName"] + "", row["CustTel"] + "", double.Parse(row["TotalInterest"] + ""));
                panStuffItems.Controls.Add(item);
            }
        }
    }
}