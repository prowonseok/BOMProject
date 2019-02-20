using BOM.VO;
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
        List<RevenueVO> RevenueList1 = new List<RevenueVO>();

        internal List<RevenueVO> Revenue(string startDate, string endDate)
        {
            RevenueList1.Clear();
            string sp = "Bom_JW_Revenue";
            SqlParameter[] sqlParameter = new SqlParameter[2];
            sqlParameter[0] = new SqlParameter("@startDate", startDate);
            sqlParameter[1] = new SqlParameter("@endDate", endDate);

            dt = dbp.ExecuteParametersDT(sp, sqlParameter);

            foreach (DataRow item in dt.Rows)
            {
                RevenueList1.Add(new RevenueVO
                {
                    OrderNo = Int32.Parse(item["Cus_Order_No"].ToString()),
                    OrderDate = DateTime.Parse(item["Cus_Order_Date"].ToString()),
                    OrderPrice = String.Format("{0:##,##0}", Int32.Parse(item["Cus_Order_Price"].ToString())) + " 원"
            });
            }
            return RevenueList1;
        }


    }
}
