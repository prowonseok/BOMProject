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
        private DBProcessor con;

        public MatDAO()
        {
            con = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public void InsertMat(int mat_Type_No, string mat_Type_Category)
        {
            string sp = "Materials_Type_Insert_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@mat_Type_No", mat_Type_No);
            sqlParameters[1] = new SqlParameter("@mat_Type_Category", mat_Type_Category);
            con.ExecuteParameters(sp, sqlParameters);
        }

        public void DeleteMat(int mat_Type_No1, int mat_Type_No2)
        {
            string sp = "Materials_Type_Delete_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@mat_Type_No1", mat_Type_No1);
            sqlParameters[1] = new SqlParameter("@mat_Type_No2", mat_Type_No2);

            con.ExecuteParameters(sp, sqlParameters);
        }

        public DataTable SelectMat(string sp)
        {
            return con.ExecuteParametersDT(sp, null);
        }
    }
}