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
        /// <summary>
        /// 제품가격 변경하는 메서드
        /// </summary>
        /// <param name="ProNo">제품 번호</param>
        /// <param name="Price">변경할 가격</param>
        /// <returns>결과를 bool타입으로 반환</returns>
        internal bool PriceUpdate(int ProNo, int ChangPrice)        
        {
            string sp = "Bom_JW_ProPriceChinge_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@no", ProNo);
            sqlParameters[1] = new SqlParameter("@Price", ChangPrice);

           
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sp">프로시저 이름</param>
        /// <param name="search">조회할 변수</param>
        /// <param name="search2">조회할 변수</param>
        /// <param name="parameter1">파라메터 변수1</param>
        /// <param name="parameter2">파라메터 변수2</param>
        /// <returns>조회한 데이터리스트 반환</returns>
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
        /// <summary>
        /// 제품이름으로 제품의 고유번호 반환하는 메서드
        /// </summary>
        /// <param name="ProName">제품 이름</param>
        /// <returns>제품번호 반환</returns>
        internal int ProNo(string ProName)
        {
            string sp = "Bom_JW_GetProNo";
            SqlParameter[] s = new SqlParameter[1];
            s[0] = new SqlParameter("@proName", ProName);
            int ProNo = 0;
            foreach (DataRow item in dbp.ExecuteParametersDT(sp, s).Rows)
            {
                ProNo =Int32.Parse(item["Pro_No"].ToString());
            }
            return ProNo;            
        }
        /// <summary>
        /// 제품 목록을 반환하는 메서드
        /// </summary>
        /// <returns>제품목록 리스트 반환</returns>
        internal List<ProductsListVO> ProList()
        {
            string sp = "Bom_JW_ProNameSelect2";
            List<ProductsListVO> productcList = new List<ProductsListVO>();
            productcList.Clear();

            DataTable dataTable =  dbp.ExecuteParametersDT(sp, null);

            
            foreach (DataRow item in dataTable.Rows)
            {       
                try
                {
                    productcList.Add(new ProductsListVO()
                    {
                        ProductName = item["Pro_name"].ToString(),
                        ProductPrice = item["Pro_Price"].ToString(),
                        ProductDate = DateTime.Parse(item["Pro_ChangePriceDate"].ToString())

                    });
                }
                catch (FormatException)
                {

                    productcList.Add(new ProductsListVO()
                    {
                        ProductName = item["Pro_name"].ToString(),
                        ProductPrice = item["Pro_Price"].ToString(),
                        ProductDate = DateTime.Parse(DateTime.Now.ToShortDateString())

                    });
                }
            }  
            
            return productcList;
        }
        /// <summary>
        /// 자재 목록 반환하는 메서드
        /// </summary>
        /// <returns>자재목록이 담긴 데이터테이블 반환</returns>
        public DataTable MatList2()
        {
            string sp = "Bom_JW_MatView";
            List<ProductsListVO> productcList = new List<ProductsListVO>();
            productcList.Clear();

            DataTable dataTable = dbp.ExecuteParametersDT(sp, null);
            return dataTable;
        }
    }
}
