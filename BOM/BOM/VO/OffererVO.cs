using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class OffererVO
    {
        private int offNo;

        public int OffNo
        {
            get { return offNo; }
            set { offNo = value; }
        }

        private string offName;

        public string OffName
        {
            get { return offName; }
            set { offName = value; }
        }

        private string offOwnerName;

        public string OffOwnerName
        {
            get { return offOwnerName; }
            set { offOwnerName = value; }
        }

        private string offOwnerPhone;

        public string OffOwnerPhone
        {
            get { return offOwnerPhone; }
            set { offOwnerPhone = value; }
        }

        private string offaddr;

        public string OffAddr
        {
            get { return offaddr; }
            set { offaddr = value; }
        }

        private string offMgrName;

        public string OffMgrName
        {
            get { return offMgrName; }
            set { offMgrName = value; }
        }

        private string offMgrPhone;

        public string OffMgrPhone
        {
            get { return offMgrPhone; }
            set { offMgrPhone = value; }
        }

        public OffererVO(int offNo, string offName)
        {
            OffNo = offNo;
            OffName = offName;
        }

        public OffererVO(int offNo, string offName, string offOwnerName, string offOwnerPhone, string offAddr, string offMgrName, string offMgrPhone) : this(offNo, offName)
        {
            OffOwnerName = OffOwnerName;
            OffOwnerPhone = OffOwnerPhone;
            OffAddr = offAddr;
            OffMgrName = offMgrName;
            OffMgrPhone = offMgrPhone;
        }
    }
}
