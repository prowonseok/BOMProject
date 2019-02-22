using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerApp.VO;
using dllPackager;

namespace CustomerApp.DAO
{
    class AsDAO
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private DBProcessor db = new DBProcessor(conStr);
        private List<AsVO> asList = new List<AsVO>();
        private List<OrderVO> buyList = new List<OrderVO>();
        private List<int> orderNoList = new List<int>();

        public void Insert(AsVO asVO)
        {
            try
            {
                string sp = "InsertAS";
                SqlParameter[] asInfo = new SqlParameter[6];
                asInfo[0] = new SqlParameter("Cus_ID", asVO.CusNo);
                asInfo[1] = new SqlParameter("Cus_Order_No", asVO.OrderNo);
                asInfo[2] = new SqlParameter("Pro_No", asVO.ProNo);
                asInfo[3] = new SqlParameter("AS_Content", asVO.AsContent);
                asInfo[4] = new SqlParameter("AS_StartDate", asVO.AsStartDate);
                asInfo[5] = new SqlParameter("Emp_No", asVO.EmpNo);
                db.ExecuteParameters(sp, asInfo);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<OrderVO> SelectBuyPro(int cusNo)
        {
            try
            {
                buyList.Clear();
                string sp = "SelectBuyPro";
                SqlParameter[] asInfo = new SqlParameter[1];
                asInfo[0] = new SqlParameter("Cus_No", cusNo);
                var dataTable = db.ExecuteParametersDT(sp, asInfo);
                foreach (DataRow row in dataTable.Rows)
                {
                    OrderVO order = new OrderVO()
                    {
                        ProName = row["Pro_Name"].ToString(),
                        ProNo = int.Parse(row["Pro_No"].ToString())
                    };
                    buyList.Add(order);
                }
                return buyList;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<int> SelectBuyOrderNo(int cusNo, int proNo)
        {
            try
            {
                orderNoList.Clear();
                string sp = "SelectBuyOrderNo";
                SqlParameter[] asInfo = new SqlParameter[2];
                asInfo[0] = new SqlParameter("Cus_No", cusNo);
                asInfo[1] = new SqlParameter("Pro_No", proNo);
                var dataTable = db.ExecuteParametersDT(sp, asInfo);
                foreach (DataRow row in dataTable.Rows)
                {
                    orderNoList.Add(int.Parse(row["Cus_Order_No"].ToString()));
                }
                return orderNoList;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<AsVO> SelectAllAS(int cusNo)
        {
            try
            {
                asList.Clear();
                string sp = "SelectAllAS";
                SqlParameter[] asInfo = new SqlParameter[1];
                asInfo[0] = new SqlParameter("Cus_No", cusNo);
                var dataTable = db.ExecuteParametersDT(sp, asInfo);
                foreach (DataRow row in dataTable.Rows)
                {
                    string asPrice = row["AS_Price"].ToString();
                    string endDate = row["AS_EndDate"].ToString();

                    if (string.IsNullOrEmpty(asPrice)) asPrice = "측정 중..";
                    else asPrice = string.Format("{0:c}", asPrice);

                    if (string.IsNullOrEmpty(endDate)) endDate = "A/S 진행 중..";
                    else endDate = string.Format("{0:d}", endDate);

                    AsVO asVO = new AsVO()
                    {
                        CusNo = int.Parse(row["Cus_ID"].ToString()),
                        AsNo = int.Parse(row["AS_No"].ToString()),
                        OrderNo = int.Parse(row["Cus_Order_No"].ToString()),
                        EmpNo = int.Parse(row["Emp_No"].ToString()),
                        ProNo = int.Parse(row["Pro_No"].ToString()),
                        AsContent = row["AS_Content"].ToString(),
                        AsPrice = asPrice,
                        AsStartDate = DateTime.Parse(row["AS_StartDate"].ToString()),
                        AsEndDate = endDate,
                        ProName = row["Pro_Name"].ToString(),
                        CusName = row["Cus_Name"].ToString(),
                        EmpName = row["Emp_Name"].ToString()
                    };
                    asList.Add(asVO);
                }
                return asList;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
