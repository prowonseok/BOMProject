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
                }
                catch (SqlException)
                {
                    throw;
                }
            }
            return conn;
        }

        public bool ExcuteInsert(string sp, SqlParameter[] sqlParameters) {
            bool result = false;
            using (SqlTransaction transaction = OpenConn().BeginTransaction())
            {
                SqlCommand com = new SqlCommand();
                adapter.InsertCommand = com;  
                adapter.InsertCommand.Connection = OpenConn();
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.CommandText = sp;
                adapter.InsertCommand.Transaction = transaction;

                if (sqlParameters != null)
                {
                    adapter.InsertCommand.Parameters.AddRange(sqlParameters);
                }
                try
                {
                    try
                    {
                        //FALSE값이 뜨는지(중복 값 입력시)
                        com.ExecuteScalar().ToString();
                    }
                    catch (Exception)
                    {
                        result = true;
                    }
                    com.ExecuteNonQuery();
                    transaction.Commit();
                    
                }
                catch (SqlException)
                {
                    transaction.Rollback();
                } 
            }
            return result;
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
        public interface IDBCRUD
        {
            void Insert();
            void Update();
            void Delete();
        }
    }
}