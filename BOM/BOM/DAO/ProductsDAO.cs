using dllPackager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.DAO
{
    class ProductsDAO
    {
        private DBProcessor dp;

        public ProductsDAO()
        {
            dp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public int InsertProducts(string mat_No, int pro_Price, string pro_Name, string pro_Spec, byte[] pro_Img)
        {
            try
            {
                string sp = "Products_Insert_Procedure";
                SqlParameter[] sqlParameters = new SqlParameter[5];
                sqlParameters[0] = new SqlParameter("@mat_No", mat_No);
                sqlParameters[1] = new SqlParameter("@pro_Price", pro_Price);
                sqlParameters[2] = new SqlParameter("@pro_Name", pro_Name);
                sqlParameters[3] = new SqlParameter("@pro_Spec", pro_Spec);
                sqlParameters[4] = new SqlParameter("@pro_Img", pro_Img);
                return dp.ExecuteParameters(sp, sqlParameters);
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
