using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerApp.VO;
using dllPackager;

namespace CustomerApp.DAO
{
    class CartDAO
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private DBProcessor db = new DBProcessor(conStr);

        public void Insert(CartVO cart)
        {
            string sp = "InsertCart";
            SqlParameter[] cusInfo = new SqlParameter[5];
            cusInfo[0] = new SqlParameter("cusNo", cart.CusNo);
            cusInfo[1] = new SqlParameter("saveNo", cart.SaveNo);
            cusInfo[2] = new SqlParameter("proNo", cart.ProNo);
            cusInfo[3] = new SqlParameter("saveEA", cart.SaveEA);
            cusInfo[4] = new SqlParameter("cartDate", cart.CartDate);
            try
            {
                db.ExecuteParameters(sp, cusInfo);
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
