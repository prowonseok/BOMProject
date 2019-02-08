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
    class SalesDao
    {
        DBProcessor dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);       
        
        internal bool PriceUpdate(int indexNo, int Price)        
        {
            string sp = "Bom_JW_ProPriceChinge_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@no", indexNo);
            sqlParameters[1] = new SqlParameter("@Price", Price);

           
            bool TrueFalse = false;  
            try
            {              
                if (dbp.ExecuteParameters(sp, sqlParameters) != -1)
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
            int parameterCount =1;
            if (search2 != "") // 두개의 입력값 있을시 배열의 크기를 증가시킴
            {
                parameterCount ++;
            }
            SqlParameter[] sqlParameters = new SqlParameter[parameterCount]; 
            
            if (search==""&& parameter1=="")
            {
                sqlParameters = null;
            }
            else
            {
                sqlParameters[0] = new SqlParameter(parameter1, search);
            }
            if (search2 !="")
            {
                sqlParameters[1] = new SqlParameter(parameter2, search2);
            }
            DataTable dateTable =  dbp.ExecuteParametersDT(sp, sqlParameters);

            foreach (DataRow item in dateTable.Rows)
            {
                salesList.Add(new SalesVO()
                {
                    OrderNo = Int32.Parse(item["Cus_Order_OrderNo"].ToString()),
                    CusID = item["Cus_ID"].ToString(),
                    EmpID = item["Emp_Name"].ToString(),
                    Pro_No = item["Pro_Name"].ToString(),
                    Price = Int32.Parse(item["Cus_Order_Price"].ToString()),
                    Ea = Int32.Parse(item["Cus_Order_EA"].ToString()),
                    OrderDate = DateTime.Parse(item["Cus_Order_Date"].ToString()),
                    OrderComplete = item["Com_Type"].ToString(),
                });
            }            
            return salesList;
        }

        internal List<ProductsListVO> ComboProDuctList(string sp)
        {
            List<ProductsListVO> productcList = new List<ProductsListVO>();
            productcList.Clear();

            DataTable dataTable =  dbp.ExecuteParametersDT(sp, null);

            foreach (DataRow item in dataTable.Rows)
            {
                productcList.Add(new ProductsListVO()
                {
                    ProductName = item["Pro_name"].ToString(),
                    ProductPrice = item["Pro_Price"].ToString(),
                    ProductDate = DateTime.Parse(item["Pro_ChangePriceDate"].ToString())

                });
            }  
            
            return productcList;
        }

        
    }
}
