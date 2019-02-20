using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class OffererOrderViewVO
    {
        private int mat_No;
        public int Mat_No
        {
            get { return mat_No; }
            set { mat_No = value; }
        }

        private int off_No;
        public int Off_No
        {
            get { return off_No; }
            set { off_No = value; }
        }

        private string mat_Name;
        public string Mat_Name
        {
            get { return mat_Name; }
            set { mat_Name = value; }
        }

        private string off_Name;
        public string Off_Name
        {
            get { return off_Name; }
            set { off_Name = value; }
        }

        private int mat_Cost;
        public int Mat_Cost
        {
            get { return mat_Cost; }
            set { mat_Cost = value; }
        }


        public OffererOrderViewVO(int mat_No, int off_No, string mat_Name, string off_Name, int mat_Cost)
        {
            Mat_No = mat_No;
            Off_No = off_No;
            Mat_Name = mat_Name;
            Off_Name = off_Name;
            Mat_Cost = mat_Cost;
        }
    }
}
