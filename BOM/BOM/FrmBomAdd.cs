using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.VO;

namespace BOM
{
    public partial class FrmBomAdd : Form
    {
        private Materials materials;

        public FrmBomAdd() {
            InitializeComponent();
        }

        public FrmBomAdd(Materials materials)
        {
            this.materials = materials;
            InitializeComponent();
        }

        private void btnPMatSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnMatSearch_Click(object sender, EventArgs e)
        {
            //모 품번이 없을 때
            if (string.IsNullOrEmpty(txtParentMatNo.Text))
            {
                MessageBox.Show("상위 품목을 먼저 설정해주세요.");
            }
            else
            {//level값보다 낮은
                FrmBomAllMatInfo fbami = new FrmBomAllMatInfo(materials.Mat_Level);
                fbami.ShowDialog();
            }
        }

        private void FrmBomAdd_Load(object sender, EventArgs e)
        {
            try
            {
                //BOM 조회에서 등록으로 이동하는 경우
                txtParentMatNo.Text = materials.Mat_No.ToString();
                txtParentMatName.Text = materials.Mat_Name;
            }
            catch (Exception)
            {
                //BOM 등록을 바로 들어가는 경우
                
            }

        }

        
    }
}
