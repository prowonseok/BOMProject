using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class AddressVO
    {
        private int zipNo;
        private string nameAddr;
       // private string RoadNameAddr;

        public int ZipNo { get => zipNo; set => zipNo = value; }
        public string NameAddr { get => nameAddr; set => nameAddr = value; }
        //public string RoadNameAddr1 { get => RoadNameAddr; set => RoadNameAddr = value; }
    }
}
