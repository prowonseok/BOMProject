using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class ASVO
    {
        private int as_No;
        public int AS_No
        {
            get { return as_No; }
            set { as_No = value; }
        }

        private int cus_Order_No;
        public int Cus_Order_No
        {
            get { return cus_Order_No; }
            set { cus_Order_No = value; }
        }

        private int emp_No;
        public int Emp_No
        {
            get { return emp_No; }
            set { emp_No = value; }
        }

        private int pro_No;
        public int Pro_No
        {
            get { return pro_No; }
            set { pro_No = value; }
        }

        private string as_Content;
        public string AS_Content
        {
            get { return as_Content; }
            set { as_Content = value; }
        }

        private int as_Price;
        public int AS_Price
        {
            get { return as_Price; }
            set { as_Price = value; }
        }

        private DateTime as_StartDate;
        public DateTime AS_StartDate
        {
            get { return as_StartDate; }
            set { as_StartDate = value; }
        }

        private DateTime as_EndDate;
        public DateTime AS_EndDate
        {
            get { return as_EndDate; }
            set { as_EndDate = value; }
        }

        private int cus_ID;
        public int Cus_ID
        {
            get { return cus_ID; }
            set { cus_ID = value; }
        }

        public ASVO(int as_No, int cus_Order_No, int emp_No, int pro_No, string as_Content, int as_Price, DateTime as_StartDate, DateTime as_EndDate, int cus_ID)
        {
            AS_No = as_No;
            Cus_Order_No = cus_Order_No;
            Emp_No = emp_No;
            Pro_No = pro_No;
            AS_Content = as_Content;
            AS_Price = as_Price;
            AS_StartDate = as_StartDate;
            AS_EndDate = as_EndDate;
            Cus_ID = cus_ID;
        }
    }
}