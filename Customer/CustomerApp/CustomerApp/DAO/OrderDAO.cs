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

        private List<OrderVO> SelectOrderByCusID()
        {
            string sp = "SelectOrderByCusID";
            try
            {
                var dataTable = db.ExecuteParametersDT(sp, null);
                foreach (DataRow row in dataTable.Rows)
                {
                    OrderVO order = new OrderVO()
                    {
                        OrderNo = int.Parse(row["Cus_Order_No"].ToString()),
                        Order_OrderNo = int.Parse(row["Cus_Order_OrderNo"].ToString()),
                        OrderCusId = int.Parse(row["Cus_ID"].ToString()),
                        OrderProNo = int.Parse(row["Pro_No"].ToString()),
                        OrderDate = DateTime.Parse(row["Cus_Order_Date"].ToString()),
                        OrderEa = int.Parse(row["Cus_Order_EA"].ToString()),
                        OrderPrice = int.Parse(row["Cus_Order_Price"].ToString()),
                        EmpNo = 1
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

        internal void Insert(OrderVO order)
        {
            string sp = "InsertOrder";
            SqlParameter[] cusInfo = new SqlParameter[6];
            cusInfo[0] = new SqlParameter("Cus_ID", order.OrderCusId);
            cusInfo[1] = new SqlParameter("Pro_No", order.OrderProNo);
            cusInfo[2] = new SqlParameter("Cus_Order_OrderNo", order.Order_OrderNo);
            cusInfo[3] = new SqlParameter("Cus_Order_Date", order.OrderDate);
            cusInfo[4] = new SqlParameter("Cus_Order_Price", order.OrderPrice);
            cusInfo[5] = new SqlParameter("Cus_Order_EA", order.OrderEa);
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
