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
            Connection = new SqlConnection("SERVER=localhost;DATABASE=SAPAWN;TRUSTED_CONNECTION=TRUE");
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
            Connection = new SqlConnection("SERVER=" + SERVER + ";DATABASE=" + DATABASE + ";TRUSTED_CONNECTION=TRUE");
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
            Connection = new SqlConnection("Server=" + SERVER + ";Database=" + DATABASE + ";User Id=" + Username + ";Password=" + Password);
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
        public static bool ExecuteNonQuery(string sql, SqlParameter[] param = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);

                if (param != null)
                    cmd.Parameters.AddRange(param);

                bool x = Convert.ToBoolean(cmd.ExecuteNonQuery());
                cmd.Dispose();
                return x;
            }
            catch (Exception) { return false; }
        }

        ///<Summary>
        /// Execute with Return a value as object
        ///
        ///</Summary>
        public static object ExecuteScalar(string sql, SqlParameter[] param = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);

                if (param != null)
                    cmd.Parameters.AddRange(param);

                object value = cmd.ExecuteScalar();
                cmd.Dispose();
                return value;
            }
            catch (Exception) { return null; }
        }

        /// <summary>
        /// Use for return Datatable
        /// </summary>
        /// <param name="sql">Select Command</param>
        /// <returns></returns>
        public static DataTable GetModel(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, Connection);
                adapter.Fill(dt);
                adapter.Dispose();
                return dt;
            }
            catch (Exception) { return null; }
        }

        /// <summary>
        /// Use for get parameters
        /// </summary>
        /// <param name="values">Can be text or number , Parameter is @obj#</param>
        /// <returns>Return value to use in ExecuteScalar and ExecuteNonQuery</returns>
        public static SqlParameter[] GetParams(object[] values)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                for (int i = 0; i < values.Length; i++)
                {
                    SqlParameter param = new SqlParameter();
                    param.Value = values[i];
                    param.ParameterName = "@obj" + (i + 1);
                    parameters.Add(param);
                }
                return parameters.ToArray();
            }
            catch (Exception) { return null; }
        }

        /// <summary>
        ///
        /// </summary>
        public static void BindGridView(DataGridView dg)
        {
        }
    }

    public class Test
    {
        public static int logUser(string user, string pass, ref string FullName)
        {
            try
            {
                DataTable usr = Connect.GetModel("SELECT * FROM [User] WHERE [Username] = '" + user + "' AND [Password] = '" + pass + "' AND [Status] = 1;");
                DataRow r = usr.Rows[0];
                FullName = r["Username"] + "";
                return int.Parse(r["UID"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static bool config(string server, string dbname, string user = null, string pass = null)
        {
            try
            {
                return user != null && pass != null ? Connect.Open(server, dbname, user, pass) : Connect.Open(server, dbname);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}