using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_PAWN_Company.Reports
{
    public class ST_Schedule
    {
        public int ShcId { get; set; }
        public int PawnId { get; set; }
        public string PawnDate { get; set; }
        public string PayDate { get; set; }
        public string Duration { get; set; }
        public double PawnPrice { get; set; }
        public int PayCount { get; set; }
        public int Rate { get; set; }
        public double Interest { get; set; }
        public double AmountPay { get; set; }
        public double TotalPay { get; set; }
        public string CustTel { get; set; }
    }
}