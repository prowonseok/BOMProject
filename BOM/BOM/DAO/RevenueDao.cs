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
    
    class RevenueDao
    {
        DBProcessor dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        DataTable dt = new DataTable();

        internal DataTable Revenue(string startDate, string endDate)
        {
            string sp = "Bom_JW_Revenue";
            SqlParameter[] sqlParameter = new SqlParameter[2];
            sqlParameter[0] = new SqlParameter("@startDate", startDate);
            sqlParameter[1] = new SqlParameter("@endDate", endDate);

            dt = dbp.ExecuteParametersDT(sp, sqlParameter);            
            return dt;

        }
    }
}
