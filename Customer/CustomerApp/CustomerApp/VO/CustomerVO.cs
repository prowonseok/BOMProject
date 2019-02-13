using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.VO
{
    public class CustomerVO
    {
        private int no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string addr;

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }

        private string pw;

        public string Pw
        {
            get { return pw; }
            set { pw = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
