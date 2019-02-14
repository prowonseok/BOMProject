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
    public partial class FrmBomUpdate : Form
    {
        Materials materials;
        DAO.BomDAO bDao;
        int ea;
        int pNo;
        public FrmBomUpdate(int pNo, Materials materials, int ea)
        {
            this.pNo = pNo;
            this.ea = ea;
            this.materials = materials;
            InitializeComponent();
        }

        private void FrmBomUpdate_Load(object sender, EventArgs e)
        {
            txtMatNo.Text = materials.Mat_No.ToString();
            txtMatName.Text = materials.Mat_Name;
            txtEa.Text = ea.ToString();
            txtEa.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEa.Text, out int ea))
            {
                bDao = new DAO.BomDAO();
                //부모 번호, 자식 번호, 자식 개수
                if (bDao.UpdateBom(pNo, materials.Mat_No, ea))
                {
                    MessageBox.Show("수정 성공");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("수정 실패");
                }
            }
            else
            {
                MessageBox.Show("숫자를 입력해주세요");
                txtEa.Focus();
            }
        }
    }
}
