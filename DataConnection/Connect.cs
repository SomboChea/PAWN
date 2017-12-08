using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace DataConnection
{
    public class Connect
    {
        public static SqlConnection Connection { get; set; }

        ///<Summary>
        /// Open the Connection
        /// Cautious : Only using in SA_PAWN
        /// fix SERVER and DATABASE
        ///</Summary>

        public static bool Open()
        {
            Connection = new SqlConnection("SERVER=localhost;DATABASE=,TRUSTED_CONNECTION=TRUE");
            try { Connection.Open(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        ///<Summary>
        /// Open the Connection
        ///</Summary>
        public static bool Open(string SERVER, string DATABASE)
        {
            Connection = new SqlConnection("SERVER=" + SERVER + ";DATABASE=" + DATABASE + ",TRUSTED_CONNECTION=TRUE");
            try { Connection.Open(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        ///<Summary>
        /// Open the Connection
        ///</Summary>
        public static bool Open(string SERVER, string DATABASE, string Username, string Password)
        {
            Connection = new SqlConnection("SERVER=" + SERVER + ";DATABASE=" + DATABASE + ",UserID=" + Username + ",Password=" + Password);
            try { Connection.Open(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static void Close()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Execute without Return anything
        /// </summary>
        /// <param name="sql">Command Select</param>
        /// <param name="param">Nullable , use with command have parameter</param>
        public static void ExecuteNonQuery(string sql, SqlParameter[] param = null)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        ///<Summary>
        /// Execute with Return a value as object
        ///
        ///</Summary>
        public static object ExecuteScalar(string sql, SqlParameter[] param = null)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(param);
            object value = cmd.ExecuteScalar();
            cmd.Dispose();
            return value;
        }

        /// <summary>
        /// Use for return Datatable
        /// </summary>
        /// <param name="sql">Select Command</param>
        /// <returns></returns>
        public static DataTable GetModel(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }

        /// <summary>
        /// Use for get parameters
        /// </summary>
        /// <param name="values">Can be text or number , Parameter is @obj#</param>
        /// <returns>Return value to use in ExecuteScalar and ExecuteNonQuery</returns>
        public static List<SqlParameter> GetParams(object[] values)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            for (int i = 0; i < values.Length; i++)
            {
                SqlParameter param = new SqlParameter();
                param.Value = values[i];
                param.ParameterName = "@obj" + (i + 1);
                parameters.Add(param);
            }
            return parameters;
        }

        /// <summary>
        ///
        /// </summary>
        public static void BindGridView(DataGridView dg)
        {
        }
    }
}