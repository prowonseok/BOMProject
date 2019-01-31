using BOM.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.DAO
{
    class SalesDao
    {
        internal void PriceUpdate()
        {

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
            SqlDataReader sr = new DBConnection().GetProductList(sp);

            while (sr.Read())
            {
                productcList.Add(new ProductsListVO()
                {
                    ProductName = sr["Pro_name"].ToString(),
                    ProductPrice = sr["Pro_Price"].ToString()
                });
            }            
            
            return productcList;
        }

        
    }
}
