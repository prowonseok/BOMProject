using Microsoft.VisualStudio.TestTools.UnitTesting;
using dllPackager;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CusAppTest
{
    [TestClass]
    public class DBTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string conStr = "Data Source=finalprojectbom.database.windows.net;Initial Catalog=FinalProject;User ID=finalproject;Password=Qwe123!@#";
            DBProcessor dB = new DBProcessor(conStr);
            SqlConnection con = dB.OpenConn();

            Debug.Assert(con != null);
            Debug.Assert(con.State == System.Data.ConnectionState.Open);

            con.Close();
            Debug.Assert(con.State == System.Data.ConnectionState.Closed || con.State == System.Data.ConnectionState.Broken);
        }
    }
}
