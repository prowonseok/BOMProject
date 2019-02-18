using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllPackager;
using CustomerApp.VO;
using System.Data.SqlClient;

namespace CustomerApp.DAO
{
    class OrderDAO
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private DBProcessor db = new DBProcessor(conStr);

        List<OrderVO> orderList = new List<OrderVO>();

        public List<OrderVO> SelectOrderByCusID(int cusNo, int EmpNo)
        {
            string sp = "SelectOrderByCusID";
            try
            {
                SqlParameter[] cusInfo = new SqlParameter[2];
                cusInfo[0] = new SqlParameter("Cus_No", cusNo);
                cusInfo[1] = new SqlParameter("Emp_No", EmpNo);
                var dataTable = db.ExecuteParametersDT(sp, cusInfo);
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
                        EmpName = row["Emp_Name"].ToString()
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

        public void InsertSingleOrder(OrderVO order, int cusNo)
        {
            string sp = "InsertSingleOrder";
            SqlParameter[] cusInfo = new SqlParameter[6];
            cusInfo[0] = new SqlParameter("Cus_No", order.CusNo);
            cusInfo[1] = new SqlParameter("Pro_No", order.ProNo);
            cusInfo[2] = new SqlParameter("Cus_Order_OrderNo", GetOrder_OrderNo(cusNo));
            cusInfo[3] = new SqlParameter("Cus_Order_Date", order.OrderDate);
            cusInfo[4] = new SqlParameter("Cus_Order_Price", order.Price);
            cusInfo[5] = new SqlParameter("Cus_Order_EA", order.EA);
            try
            {
                db.ExecuteParameters(sp, cusInfo);
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
                    SqlParameter[] cusInfo = new SqlParameter[7];
                    cusInfo[0] = new SqlParameter("Cus_No", cusNo);
                    cusInfo[1] = new SqlParameter("Pro_No", cart[i].ProNo);
                    cusInfo[2] = new SqlParameter("Cus_Order_OrderNo", order_OrderNo);
                    cusInfo[3] = new SqlParameter("Cus_Order_Date", cart[i].OrderDate);
                    cusInfo[4] = new SqlParameter("Cus_Order_Price", cart[i].Price);
                    cusInfo[5] = new SqlParameter("Cus_Order_EA", cart[i].EA);
                    cusInfo[6] = new SqlParameter("Emp_No", cart[i].EmpNo);
                    db.ExecuteParameters(sp, cusInfo);
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int GetOrder_OrderNo(int cusNo)
        {
            string sp = "GetOrder_OrderNo_ByCus";
            try
            {
                int order_OrderNo;
                SqlParameter[] cusInfo = new SqlParameter[1];
                cusInfo[0] = new SqlParameter("Cus_No", cusNo);
                var dataTable = db.ExecuteParametersDT(sp, cusInfo);
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
    }
}
