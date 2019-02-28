using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using dllPackager;
using CustomerApp.VO;
using System.Data.SqlClient;

namespace CustomerApp.DAO
{
    class OrderDAO
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private DBProcessor db = new DBProcessor(conStr);

        private List<OrderVO> orderList = new List<OrderVO>();

        public List<OrderVO> SelectOrderByCusID(int cusNo)
        {
            try
            {
                orderList.Clear();
                string sp = "SelectOrderByCusID";
                SqlParameter[] orderorderInfo = new SqlParameter[1];
                orderorderInfo[0] = new SqlParameter("Cus_No", cusNo);
                var dataTable = db.ExecuteParametersDT(sp, orderorderInfo);
                foreach (DataRow row in dataTable.Rows)
                {
                    OrderVO order = new OrderVO()
                    {
                        OrderNo = int.Parse(row["Cus_Order_No"].ToString()),
                        Order_OrderNo = int.Parse(row["Cus_Order_OrderNo"].ToString()),
                        ProName = row["Pro_Name"].ToString(),
                        OrderDate = DateTime.Parse(row["Cus_Order_Date"].ToString()),
                        EA = int.Parse(row["Cus_Order_EA"].ToString()),
                        Price = int.Parse(row["Cus_Order_Price"].ToString()),
                        EmpName = row["Emp_Name"].ToString(),
                        OrderCom = row["Com_Type"].ToString()
                    };
                    orderList.Add(order);
                }
                return orderList;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void InsertSingleOrder(OrderVO order)
        {
            string sp = "InsertSingleOrder";
            SqlParameter[] orderInfo = new SqlParameter[7];
            orderInfo[0] = new SqlParameter("Cus_No", order.CusNo);
            orderInfo[1] = new SqlParameter("Pro_No", order.ProNo);
            orderInfo[2] = new SqlParameter("Cus_Order_OrderNo", GetOrder_OrderNo(order.CusNo));
            orderInfo[3] = new SqlParameter("Cus_Order_Date", order.OrderDate);
            orderInfo[4] = new SqlParameter("Cus_Order_Price", order.Price);
            orderInfo[5] = new SqlParameter("Cus_Order_EA", order.EA);
            orderInfo[6] = new SqlParameter("Emp_No", order.EmpNo);
            try
            {
                db.ExecuteParameters(sp, orderInfo);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void InsertCartOrder(List<OrderVO> cart, int cusNo)
        {
            try
            {
                string sp = "InsertCartOrder";
                int order_OrderNo = GetOrder_OrderNo(cusNo);
                for (int i = 0; i < cart.Count; i++)
                {
                    SqlParameter[] orderInfo = new SqlParameter[7];
                    orderInfo[0] = new SqlParameter("Cus_No", cusNo);
                    orderInfo[1] = new SqlParameter("Pro_No", cart[i].ProNo);
                    orderInfo[2] = new SqlParameter("Cus_Order_OrderNo", order_OrderNo);
                    orderInfo[3] = new SqlParameter("Cus_Order_Date", cart[i].OrderDate);
                    orderInfo[4] = new SqlParameter("Cus_Order_Price", cart[i].Price);
                    orderInfo[5] = new SqlParameter("Cus_Order_EA", cart[i].EA);
                    orderInfo[6] = new SqlParameter("Emp_No", cart[i].EmpNo);
                    db.ExecuteParameters(sp, orderInfo);
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int GetOrder_OrderNo(int cusNo)
        {
            try
            {
                string sp = "GetOrder_OrderNo_ByCus";
                int order_OrderNo;
                SqlParameter[] orderInfo = new SqlParameter[1];
                orderInfo[0] = new SqlParameter("Cus_No", cusNo);
                var dataTable = db.ExecuteParametersDT(sp, orderInfo);
                DataRow row = dataTable.Rows[0];
                if (dataTable.Rows[0]["Max_Order_OrderNo"].ToString() == string.Empty) order_OrderNo = 1;
                else order_OrderNo = int.Parse(row["Max_Order_OrderNo"].ToString()) + 1;
                return order_OrderNo;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void CancelOrder(int orderNo)
        {
            try
            {
                string sp = "CancelOrder";
                SqlParameter[] orderInfo = new SqlParameter[1];
                orderInfo[0] = new SqlParameter("Order_No", orderNo);
                db.ExecuteParameters(sp, orderInfo);
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
