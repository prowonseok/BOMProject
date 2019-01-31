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

        internal SqlDataReader GetSales(string sp, string search, string search2, string parameter1, string parameter2)
        {
            SqlConnection sqlcon = OpenConn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Parameters.AddWithValue(parameter1, search);
            if (search2 != "")
            {
                cmd.Parameters.AddWithValue(parameter2, search2);
            }
            try
            {
                return cmd.ExecuteReader();
                
            }
            catch (Exception ea)
            {
                System.Windows.Forms.MessageBox.Show(ea.ToString() + "GetSales단 에러");
                throw;
            }            
        }
        internal SqlDataReader GetProductList()
        {
            SqlConnection sqlcon = OpenConn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Bom_JW_ProNameSelect";
            try
            {
                return cmd.ExecuteReader();                
            }
            catch (Exception ea)
            {
                System.Windows.Forms.MessageBox.Show(ea.ToString() + "GetSales단 에러");
                throw;
            }

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

        

        private SqlTransaction GetTansaction(SqlConnection sqlCon)
        {
            return sqlCon.BeginTransaction();
        }
    }
}