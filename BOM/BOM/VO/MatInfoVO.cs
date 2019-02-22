using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class MatInfoVO
    {
        private string offName;
        private string matType;
        private string matManufactur;
        private string matName;
        private int matCost;
        private int matLevel;

        public string OffName { get => offName; set => offName = value; }
        public string MatType { get => matType; set => matType = value; }
        public string MatManufactur { get => matManufactur; set => matManufactur = value; }
        public string MatName { get => matName; set => matName = value; }
        public int MatCost { get => matCost; set => matCost = value; }
        public int MatLevel { get => matLevel; set => matLevel = value; }
    }
}
