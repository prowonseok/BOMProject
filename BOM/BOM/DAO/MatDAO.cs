using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllPackager;

namespace BOM.DAO
{
    class MatDAO
    {
        private DBProcessor dp;

        public MatDAO()
        {
            dp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public void InsertMat(int mat_No, int mat_Type_No, string mat_Manufactur, string mat_Name, int mat_Cost, int mat_Level, int mat_EA, int off_No)
        {
            try
            {
                string sp = "Materials_Insert_Procedure";
                SqlParameter[] sqlParameters = new SqlParameter[8];
                sqlParameters[0] = new SqlParameter("@mat_No", mat_No);
                sqlParameters[1] = new SqlParameter("@mat_Type_No", mat_Type_No);
                sqlParameters[2] = new SqlParameter("@mat_Manufactur", mat_Manufactur);
                sqlParameters[3] = new SqlParameter("@mat_Name", mat_Name);
                sqlParameters[4] = new SqlParameter("@mat_Cost", mat_Cost);
                sqlParameters[5] = new SqlParameter("@mat_Level", mat_Level);
                sqlParameters[6] = new SqlParameter("@mat_EA", mat_EA);
                sqlParameters[7] = new SqlParameter("@off_No", off_No);
                dp.ExecuteParameters(sp, sqlParameters);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public void InsertMatType(string mat_Type_No, string mat_Type_Category)
        {
            try
            {
                string sp = "Materials_Type_Insert_Procedure";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@mat_Type_No", mat_Type_No);
                sqlParameters[1] = new SqlParameter("@mat_Type_Category", mat_Type_Category);
                dp.ExecuteParameters(sp, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteMat(int mat_Type_No1, int mat_Type_No2)
        {
            try
            {
                string sp = "Materials_Delete_Procedure";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@mat_No1", mat_Type_No1);
                sqlParameters[1] = new SqlParameter("@mat_No2", mat_Type_No2);

                dp.ExecuteParameters(sp, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectMat(string sp)
        {
            return dp.ExecuteParametersDT(sp, null);
        }
    }
}