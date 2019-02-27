using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerApp.BUS;

namespace CusAppTest
{
    [TestClass]
    public class FrmMainTest
    {
        FrmMain frmMain = new FrmMain();
        Button button = new Button();
        Label label = new Label();
        Panel panBottom = new Panel();
        Button panButton = new Button();

        [TestMethod]
        public void TestMethod1()
        {
            button.Visible = false;
            label.Visible = false;

            
            frmMain.CtrlVisiTrue(button, label);

            Debug.Assert(button.Visible); // 예상 결과 true -> PASS
            Debug.Assert(label.Visible); // 예상 결과 true -> PASS
        }

        [TestMethod]
        public void TestMethod2()
        {
            panButton.Visible = true;
            panBottom.Controls.Add(panButton);
            frmMain.PanBottomCtrlVisiFalse();

            Debug.Assert(panButton.Visible); // 예상 결과 false  -> PASS
        }
    }
}
