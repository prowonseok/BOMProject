using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.VO
{
    internal class SearchAddrResult
    {
        private string addr;

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }

        private string post;

        public string Post
        {
            get { return post; }
            set { post = value; }
        }
    }
}
