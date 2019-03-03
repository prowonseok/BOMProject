using dllPackager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.DAO
{
    class ASDAO
    {
        DBProcessor dp;

        public ASDAO()
        {
            dp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public DataTable SelectAS()
        {
            string sp = "AS_Select_Procedure";
            return dp.ExecuteParametersDT(sp, null);
        }

        public void SetASDate(int as_No)
        {
            string sp = "AS_DateSet_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@as_No", as_No);
            dp.ExecuteParameters(sp, sqlParameters);
        }

        public DataTable ASDetailsSelect()
        {
            string sp = "AS_Details_Select_Procedure";
            return dp.ExecuteParametersDT(sp, null);
        }
    }
}
