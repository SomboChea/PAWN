using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_PAWN_Company
{
    public class Connection
    {
        public SqlParameter[] GetParam(object[] Param)
        {
            List<SqlParameter> Parameters = new List<SqlParameter>();
            for (int i = 0; i < Param.Length; i++)
            {
                SqlParameter value = new SqlParameter("@obj" + (i + 1), Param[i]);
                Parameters.Add(value);
            }
            return Parameters.ToArray();
        }


    }
}
