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
    class OfferOrderDAO
    {
        private DBProcessor dp;

        public OfferOrderDAO()
        {
            dp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public DataTable SelectOrderList()
        {
            string sp = "Offerer_Order_List_View_Procedure";
            return dp.ExecuteParametersDT(sp, null);
        }

        public DataTable SelectOrder()
        {
            string sp = "Offerer_Order_View_Procedure";
            return dp.ExecuteParametersDT(sp, null);
        }

        public int InsertOrder(int off_Order_OrderNo, int mat_No, int off_Order_EA, int off_No)
        {
            try
            {
                string sp = "Offerer_Order_Insert_Procedure";
                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter("@off_Order_OrderNo", off_Order_OrderNo);
                sqlParameters[1] = new SqlParameter("mat_No", mat_No);
                sqlParameters[2] = new SqlParameter("off_Order_EA", off_Order_EA);
                sqlParameters[3] = new SqlParameter("off_No", off_No);

                return dp.ExecuteParameters(sp, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
