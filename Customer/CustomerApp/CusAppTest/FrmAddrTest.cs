using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Windows.Forms;

namespace CusAppTest
{
    [TestClass]
    public class FrmAddrTest
    {
        static string searchType = string.Empty;
        RadioButton rdoDong = new RadioButton();
        RadioButton rdoRoad = new RadioButton();
        RadioButton rdoPost = new RadioButton();

        private string getSearchType()
        {
            if (rdoDong.Checked) searchType = "dong";
            else if (rdoRoad.Checked) searchType = "road";
            else if (rdoPost.Checked) searchType = "post";

            return searchType;
        }

        [TestMethod]
        public void TestMethod1()
        {
            rdoDong.Checked = true;
            Debug.Assert(getSearchType() == "dong");

            rdoDong.Checked = false;
            rdoPost.Checked = true;
            Debug.Assert(getSearchType() == "post");

            rdoPost.Checked = false;
            rdoRoad.Checked = true;
            Debug.Assert(getSearchType() == "road");
        }
    }
}
