using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login.Connection
{
    class SQLServerConnection
    {
        public static string stringconnection = "Data Source = DESKTOP-PMNOU3J\\SQLEXPRESS; Initial Catalog = test; Integrated Security = True ";

        public static DataTable executeSQL(string sql)
        {
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                conn.ConnectionString = stringconnection;
                conn.Open();

                adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
                conn.Close();
                conn = null;
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤:" + ex.Message, 
                    "SQL Server Connection Failed : iBasskung Tutorial",MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }
    }
}
