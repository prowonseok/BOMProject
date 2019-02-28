using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CusAppTest
{

    [TestClass]
    public class FrmMainTest
    {
        Button button = new Button();
        Label label = new Label();
        Panel panBottom = new Panel();
        Button panButton = new Button();

        private void CtrlVisiTrue(params Control[] controls)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Visible = true;
            }
        }

        private void PanBottomCtrlVisiFalse()
        {
            for (int i = 0; i < panBottom.Controls.Count; i++)
            {
                panBottom.Controls[i].Visible = false;
            }
        }


        [TestMethod]
        public void TestMethod1()
        {
            button.Visible = false;
            label.Visible = false;
            CtrlVisiTrue(button, label);

            Debug.Assert(button.Visible); // 예상 결과 true -> PASS
            Debug.Assert(label.Visible); // 예상 결과 true -> PASS
        }

        [TestMethod]
        public void TestMethod2()
        {
            panButton.Visible = true;
            panBottom.Controls.Add(panButton);
            PanBottomCtrlVisiFalse();

            Debug.Assert(panButton.Visible); // 예상 결과 false  -> PASS
        }
    }
}
