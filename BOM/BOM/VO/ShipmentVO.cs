using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class ShipmentVO
    {
        private string proName;
        private int proEa;
        private int proPrice;
        private int residualAmount;

        public string ProName { get => proName; set => proName = value; }
        public int ProEa { get => proEa; set => proEa = value; }
        public int ProPrice { get => proPrice; set => proPrice = value; }
        public int ResidualAmount { get => residualAmount; set => residualAmount = value; }
    }
}
