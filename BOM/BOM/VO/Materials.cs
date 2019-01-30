using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    public class Materials
    {
        private int mat_No;
        private int mat_Type_No;
        private string mat_Manufactur;
        private string mat_Name;
        private int mat_Cost;
        private int mat_Level;
        private int mat_Ea;
        private int off_No;

        public int Mat_No { get => mat_No; set => mat_No = value; }
        public int Mat_Type_No { get => mat_Type_No; set => mat_Type_No = value; }
        public string Mat_Manufactur { get => mat_Manufactur; set => mat_Manufactur = value; }
        public string Mat_Name { get => mat_Name; set => mat_Name = value; }
        public int Mat_Cost { get => mat_Cost; set => mat_Cost = value; }
        public int Mat_Level { get => mat_Level; set => mat_Level = value; }
        public int Mat_Ea { get => mat_Ea; set => mat_Ea = value; }
        public int Off_No { get => off_No; set => off_No = value; }
    }
}
