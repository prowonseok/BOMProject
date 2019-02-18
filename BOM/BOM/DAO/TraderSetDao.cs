using dllPackager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.DAO
{
    class TraderSetDao
    {
        DBProcessor dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        //거래처 등록 메서드
        
        internal string OffInsert(string OffName, string OwnerName, string OffAddr, string mgr, string mgrMobile, string OffMobile)
        {
            string sp = "Bom_JW_OffInsert";
            SqlParameter[] sqlParameters;
            int sqlParameterSize = 5;
            string result = "";            
            
            if (OffMobile != null)
            {
                sqlParameterSize++;
            }
            sqlParameters = new SqlParameter[sqlParameterSize];
            sqlParameters[0] = new SqlParameter("@OffName", OffName);
            sqlParameters[1] = new SqlParameter("@OwnerName", OwnerName);
            sqlParameters[2] = new SqlParameter("@OffAddr", OffAddr);
            sqlParameters[3] = new SqlParameter("@offMgrName", mgr);
            sqlParameters[4] = new SqlParameter("@OffMgrPhone", mgrMobile);
            if (OffMobile != null)
            {
                sqlParameters[5] = new SqlParameter("@OwnerPhone", OffMobile);
            }

            if (dbp.ExecuteParameters(sp, sqlParameters) != 0)
            {
                result = "등록성공";
            }
            else
            {
                result = "등록실패";
            }
            return result;            
        }

        internal DataTable proTypeList()
        {
            DataTable proTypeList = new DataTable();
            string sp = "Bom_JW_ProType";
            try
            {
                proTypeList = dbp.ExecuteParametersDT(sp, null);
            }
            catch (Exception)
            {

                throw;
            }
            return proTypeList;
                
        }

       
        internal DataTable OffList()
        {
            DataTable offList = new DataTable();
            string sp = "Bom_JW_OffList";

            try
            {
                offList = dbp.ExecuteParametersDT(sp, null);
                
            }
            catch (Exception)
            {
                throw;
            }
            return offList;

        }

        internal string MatInsert(int typeNo, string MatManufactur, string MatName, int MatCost, string MatLevel, int @MatEA, int offNo)
        {
            string sp = "BomJW_PMatInsert";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@MatTypeNo", typeNo);
            sqlParameters[1] = new SqlParameter("@MatManufactur", MatManufactur);
            sqlParameters[2] = new SqlParameter("@MatName", MatName);
            sqlParameters[3] = new SqlParameter("@MatCost", MatCost);
            sqlParameters[4] = new SqlParameter("@MatLevel", MatLevel);
            sqlParameters[5] = new SqlParameter("@MatEA", @MatEA);
            sqlParameters[6] = new SqlParameter("@OffNo", offNo);
            if (dbp.ExecuteParameters(sp, sqlParameters) != 0)
            {
                return "저장성공";
            }
            else
            {
                return "저장실패";
            }
        }
        
    }
}
