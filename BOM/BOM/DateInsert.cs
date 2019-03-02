using dllPackager;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace BOM
{
    class DateInsert
    {
        public string DateInsert1()
        {
            int year = 0;
            int month = 0;
            int day = 0;
            

            DateTime dt;
            Random rd = new Random();
            
            DBProcessor dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            int cusno = 0;
            int empno = 0;
            int prono = 0;
            int cusorderorderno = 0;
            string date = null;
            int price = 0;
            int ea = 0;

            string sp1 = "DataInsertProPrice";
            SqlParameter[] sqlParameter1 = new SqlParameter[1];
            string sp2 = "DataInsert";
            SqlParameter[] sqlParameters2 = new SqlParameter[8];
            int errorCheck = 0;
            for (int i = 0; i < 50; i++) // >> 버튼 한번클릭마다 인트 i = 0 초기값을 올려줘야함
            {
                try
                {
                    errorCheck++;
                    price = 0;
                    prono = new Random().Next(24, 28);
                    ea = new Random().Next(1, 4);
                    year = rd.Next(2019, (int)DateTime.Today.Year+1);
                    month = rd.Next(1, 3);
                    day = rd.Next(1, 28);
                    date = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
                    dt = DateTime.Parse(date);
                    /////////////////////////////////////////////////////////////////////////////
                    sqlParameter1[0] = new SqlParameter("@pro_No", prono);
                    //dbp.ExecuteParametersDT(sp1, sqlParameter1);
                    foreach (DataRow item in dbp.ExecuteParametersDT(sp1, sqlParameter1).Rows)
                    {
                        price = Int32.Parse(item["Pro_Price"].ToString()) * ea;
                    }
                    //////////////////////////////////////////////////////////////////////////////////
                    sqlParameters2[0] = new SqlParameter("@cus_No", 10); //5~9번 있음
                    sqlParameters2[1] = new SqlParameter("@emp_No", new Random().Next(1, 5)); //4명
                    sqlParameters2[2] = new SqlParameter("@pro_No", prono); //6개
                    sqlParameters2[3] = new SqlParameter("@cus_Order_OrderNo", i+1047); // >> 버튼 한번클릭마다 인트 i = 0 초기값을 올려줘야함
                    sqlParameters2[4] = new SqlParameter("@cus_Order_Date", dt);
                    sqlParameters2[5] = new SqlParameter("@cus_OrderComplete", 2); //2번고정
                    sqlParameters2[6] = new SqlParameter("@cus_Order_Price", price);
                    sqlParameters2[7] = new SqlParameter("@cus_Order_EA", ea);
                    dbp.ExecuteParameters(sp2, sqlParameters2);
                }
                catch (Exception)
                {

                    return errorCheck.ToString() + "번째에서 멈춤";
                }
                
            }
            return "완료";
        }
    }
}