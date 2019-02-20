using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.BUS.Managements
{
    public class OrderInfo
    {
        private int mat_No;
        public int Mat_No
        {
            get { return mat_No; }
            set { mat_No = value; }
        }

        private string mat_Name;
        public string Mat_Name
        {
            get { return mat_Name; }
            set { mat_Name = value; }
        }

        private int off_No;
        public int Off_No
        {
            get { return off_No; }
            set { off_No = value; }
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

        private int mat_EA;
        public int Mat_EA
        {
            get { return mat_EA; }
            set { mat_EA = value; }
        }

        private int totalCost;
        public int TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        internal OrderInfo(int mat_No, string mat_Name, int off_No, string off_Name, int mat_Cost, int mat_EA, int totalCost)
        {
            Mat_No = mat_No;
            Mat_Name = mat_Name;
            Off_No = off_No;
            Off_Name = off_Name;
            Mat_Cost = mat_Cost;
            Mat_EA = mat_EA;
            TotalCost = totalCost;
        }
    }
}