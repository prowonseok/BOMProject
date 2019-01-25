using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BOM.DAO
{
    public class DBConnection
    {
        SqlConnection conn;
        internal DBConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BOM"].ConnectionString);
        }

        internal SqlConnection OpenConn()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException)
                {

                    throw;
                }
            }
            return conn;
        }
    }
}