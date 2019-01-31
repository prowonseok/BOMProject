using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace dllPackager
{
    public class DBProcessor
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;


        #region DBProcessor
        /// <summary>
        /// 데이터베이스에 접근하여 저장 프로시저를 이용한 전반적인 데이터 입출력을 관리합니다.
        /// </summary>
        /// <param name="connectionString">연결 문자열</param>
        public DBProcessor(string connectionString)
        {
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
        }
        #endregion

        #region SqlConnection.Open() 객체
        /// <summary>
        /// SqlConnection 객체를 Open 상태로 전환시킵니다.
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConn()
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
        #endregion

        #region 반환 저장 프로시저 수행 메서드
        /// <summary>
        /// 저장 프로시저를 수행 후 DataTable을 반한하기 위한 메서드 입니다.
        /// </summary>
        /// <param name="sp">저장 프로시저명</param>
        /// <param name="sqlParameters">파라미터 배열</param>
        /// <returns></returns>
        public DataTable ExecuteParametersDT(string sp, SqlParameter[] sqlParameters)
        {
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
        #endregion

        #region 저장 프로시저 수행 메서드
        /// <summary>
        /// 저장 프로시저를 수행하고 영향을 받은 행의 수를 반환하기 위한 메서드 입니다.
        /// </summary>
        /// <param name="sp">저장 프로시저명</param>
        /// <param name="sqlParameters">파라미터 배열</param>
        public int ExecuteParameters(string sp, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = OpenConn();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;

            command.Parameters.AddRange(sqlParameters);
            int affectedRows = command.ExecuteNonQuery();
            conn.Close();

            return affectedRows;
        } 
        #endregion
    }
}