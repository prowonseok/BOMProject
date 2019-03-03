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
    class ASDAO
    {
        DBProcessor dp;

        public ASDAO()
        {
            dp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }

        public DataTable SelectAS()
        {
            string sp = "AS_Select_Procedure";
            return dp.ExecuteParametersDT(sp, null);
        }

        public void SetASDate()
        {
            string sp = "AS_DateSet_Procedure";
            dp.ExecuteParameters(sp, null);
        }

        public DataTable ASDetailsSelect()
        {
            string sp = "AS_Details_Select_Procedure";
            return dp.ExecuteParametersDT(sp, null);
        }
    }
}
