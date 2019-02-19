﻿using System;
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
    class CartDAO
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private DBProcessor db = new DBProcessor(conStr);
        private List<CartVO> cartList = new List<CartVO>();

        public void Insert(CartVO cart)
        {
            try
            {
                string sp = "InsertCart";
                SqlParameter[] cusInfo = new SqlParameter[6];
                cusInfo[0] = new SqlParameter("cusNo", cart.CusNo);
                cusInfo[1] = new SqlParameter("saveNo", cart.SaveNo);
                cusInfo[2] = new SqlParameter("proNo", cart.ProNo);
                cusInfo[3] = new SqlParameter("saveEA", cart.SaveEA);
                cusInfo[4] = new SqlParameter("totalPrice", cart.TotalPrice);
                cusInfo[5] = new SqlParameter("cartDate", cart.CartDate);
                db.ExecuteParameters(sp, cusInfo);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<CartVO> Select(int cusNo)
        {
            try
            {
                cartList.Clear();
                string sp = "SelectCart";
                SqlParameter[] cusInfo = new SqlParameter[1];
                cusInfo[0] = new SqlParameter("Cus_No", cusNo);
                var dataTable = db.ExecuteParametersDT(sp, cusInfo);
                foreach (DataRow row in dataTable.Rows)
                {
                    CartVO cart = new CartVO()
                    {
                        SaveNo = int.Parse(row["Cus_Cart_Cus_SaveNo"].ToString()),
                        CusName = row["Cus_Name"].ToString(),
                        ProName = row["Pro_Name"].ToString(),
                        SaveEA = int.Parse(row["Cus_Cart_Save_EA"].ToString()),
                        TotalPrice = int.Parse(row["Cus_Cart_TotalPrice"].ToString()),
                        CartDate = DateTime.Parse(row["Cus_Cart_Date"].ToString()),
                        ProNo = int.Parse(row["Pro_No"].ToString())
                    };
                    cartList.Add(cart);
                }
                return cartList;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void Delete(int cusNo, int saveNo)
        {
            try
            {
                string sp = "DeleteCart";
                SqlParameter[] cusInfo = new SqlParameter[2];
                cusInfo[0] = new SqlParameter("Cus_No", cusNo);
                cusInfo[1] = new SqlParameter("SaveNo", saveNo);
                db.ExecuteParameters(sp, cusInfo);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public int GetSaveNo(int cusNo)
        {
            try
            {
                using (var con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = "select max(Cus_Cart_Cus_SaveNo) as SaveNo from Customers_Cart where Cus_No =" + cusNo;
                    var cmd = new SqlCommand(query, con);
                    int saveNo;

                    if (string.IsNullOrEmpty(cmd.ExecuteScalar().ToString())) saveNo = 1;
                    else saveNo = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                    con.Close();

                    return saveNo;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}