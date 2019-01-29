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
        private SqlConnection conn;
        private SqlDataAdapter adapter;


        internal DBConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BOM"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        internal SqlConnection OpenConn()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                try
                {
                    conn.Open();
                    System.Windows.Forms.MessageBox.Show("연결 성공");
                }
                catch (SqlException)
                {

                    throw;
                }
            }
            return conn;
        }

        public DataTable ExecuteSelect(string sp, SqlParameter[] sqlParameters) {

            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            adapter.SelectCommand.Connection = OpenConn();
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.CommandText = sp;

            if (sqlParameters != null)
            {
                adapter.SelectCommand.Parameters.AddRange(sqlParameters);
            }
            DataSet set = new DataSet();
            try
            {
                adapter.Fill(set);
            }
            catch (Exception)
            {
                throw;
            }
            return set.Tables[0];
        }
    }
}