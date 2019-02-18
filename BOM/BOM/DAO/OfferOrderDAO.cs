using dllPackager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.DAO
{
    class OfferOrderDAO
    {
        private DBProcessor dp;

        public OfferOrderDAO()
        {
            dp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public DataTable SelectOrder()
        {
            string sp = "Offerer_Order_Select_Procedure";
            return dp.ExecuteParametersDT(sp, null);
        }
    }
}
