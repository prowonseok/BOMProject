using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CustomerApp.VO;
using dllPackager;

namespace CustomerApp.DAO
{
    class CustomersDAO
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private DBProcessor db = new DBProcessor(conStr);
        private List<CustomerVO> cusList = new List<CustomerVO>();
        public List<CustomerVO> SelectAll()
        {
            cusList.Clear();
            string sp = "SelectAllCus";
            try
            {
                var dataTable = db.ExecuteParametersDT(sp, null);
                foreach (DataRow row in dataTable.Rows)
                {
                    CustomerVO customer = new CustomerVO()
                    {
                        No = int.Parse(row["Cus_No"].ToString()),
                        Id = row["Cus_Id"].ToString(),
                        Pw = row["Cus_Pw"].ToString(),
                        Name = row["Cus_Name"].ToString(),
                        Phone = row["Cus_Phone"].ToString(),
                        Addr = row["Cus_Addr"].ToString(),
                        Email = row["Cus_Email"].ToString()
                    };

                    cusList.Add(customer);
                }

                return cusList;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void Insert(CustomerVO customer)
        {
            string sp = "InsertCus";
            SqlParameter[] cusInfo = new SqlParameter[6];
            cusInfo[0] = new SqlParameter("id", customer.Id);
            cusInfo[1] = new SqlParameter("name", customer.Name);
            cusInfo[2] = new SqlParameter("phone", customer.Phone);
            cusInfo[3] = new SqlParameter("addr", customer.Addr);
            cusInfo[4] = new SqlParameter("pw", customer.Pw);
            cusInfo[5] = new SqlParameter("email", customer.Email);
            try
            {
                db.ExecuteParameters(sp, cusInfo);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void Update(CustomerVO customer)
        {
            string sp = "UpdateCus";
            SqlParameter[] cusInfo = new SqlParameter[5];
            cusInfo[0] = new SqlParameter("id", customer.Id);
            cusInfo[1] = new SqlParameter("addr", customer.Addr);
            cusInfo[2] = new SqlParameter("pw", customer.Pw);
            cusInfo[3] = new SqlParameter("email", customer.Email);
            cusInfo[4] = new SqlParameter("phone", customer.Phone);
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
