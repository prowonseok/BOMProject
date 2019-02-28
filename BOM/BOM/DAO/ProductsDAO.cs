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
    class ProductsDAO
    {
        private DBProcessor dp;

        public ProductsDAO()
        {
            dp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public int InsertProducts(int mat_TypeNo, string mat_Name, int mat_Cost, int pro_Price, string pro_Name, string pro_Spec, byte[] pro_Img)
        {
            try
            {
                string sp = "Products_Insert_Procedure";
                SqlParameter[] sqlParameters = new SqlParameter[7];
                sqlParameters[0] = new SqlParameter("@mat_TypeNo", mat_TypeNo);
                sqlParameters[1] = new SqlParameter("@mat_Name", mat_Name);
                sqlParameters[2] = new SqlParameter("@mat_Cost", mat_Cost);
                sqlParameters[3] = new SqlParameter("@pro_Price", pro_Price);
                sqlParameters[4] = new SqlParameter("@pro_Name", pro_Name);
                sqlParameters[5] = new SqlParameter("@pro_Spec", pro_Spec);
                sqlParameters[6] = new SqlParameter("@pro_Img", pro_Img);
                return dp.ExecuteParameters(sp, sqlParameters);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable ProSelectFromMat()
        {
            try
            {
                string sp = "Materials_Type_Product_Select_Procedure";
                return dp.ExecuteParametersDT(sp, null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
