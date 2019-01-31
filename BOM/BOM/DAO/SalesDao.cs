using BOM.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.DAO
{
    class SalesDao
    {
        DBConnection DB = new DBConnection();
        internal bool PriceUpdate(int indexNo, int Price)
        {
            bool TrueFalse = false;
            SqlConnection sqlcon = DB.OpenConn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Bom_JW_ProPriceChinge_Procedure";

            cmd.Parameters.AddWithValue("@no", indexNo);
            cmd.Parameters.AddWithValue("@Price", Price);
            try
            {
                var result = cmd.ExecuteNonQuery();
                if (result==1)
                {
                    TrueFalse = true;
                }
            }
            catch (Exception)
            {
                return false;               
            }
            return TrueFalse;
            
        }

        public List<SalesVO> SalesSelect(string sp, string search, string search2, string parameter1, string parameter2)
        {
            List<SalesVO> salesList = new List<SalesVO>();
            SqlDataReader sr = new DBConnection().GetSales(sp, search, search2, parameter1, parameter2);

            while (sr.Read())
            {
                salesList.Add(new SalesVO()
                {
                    OrderNo = Int32.Parse(sr["Cus_Order_OrderNo"].ToString()),
                    CusID = sr["Cus_ID"].ToString(),
                    EmpID = sr["Emp_Name"].ToString(),
                    Pro_No = sr["Pro_Name"].ToString(),
                    Price = Int32.Parse(sr["Cus_Order_Price"].ToString()),
                    Ea = Int32.Parse(sr["Cus_Order_EA"].ToString()),
                    OrderDate = DateTime.Parse(sr["Cus_Order_Date"].ToString()),
                    OrderComplete = sr["Cus_OrderComplete"].ToString(),                    
                });               
            }
            return salesList;
        }

        internal List<ProductsListVO> ComboProDuctList(string sp)
        {
            List<ProductsListVO> productcList = new List<ProductsListVO>();
            productcList.Clear();
            SqlDataReader sr = new DBConnection().GetProductList(sp);

            while (sr.Read())
            {
                productcList.Add(new ProductsListVO()
                {
                    ProductName = sr["Pro_name"].ToString(),
                    ProductPrice = sr["Pro_Price"].ToString(),
                    ProductDate = DateTime.Parse(sr["Pro_ChaingePriceDate"].ToString())

                });
            }            
            
            return productcList;
        }

        
    }
}
