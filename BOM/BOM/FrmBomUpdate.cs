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

        /// <summary>
        /// 매개변수로 생성자
        /// </summary>
        /// <param name="pNo"></param>
        /// <param name="materials"></param>
        /// <param name="ea"></param>
        public FrmBomUpdate(int pNo, Materials materials, int ea)
        {
            this.pNo = pNo;
            this.ea = ea;
            this.materials = materials;

            InitializeComponent();
        }
        /// <summary>
        /// Form이 Load될 때 발생하는 이벤트
        /// 생성자를 통해서 받은 값을 화면에 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBomUpdate_Load(object sender, EventArgs e)
        {
            txtMatNo.Text = materials.Mat_No.ToString();
            txtMatName.Text = materials.Mat_Name;
            txtEa.Text = ea.ToString();
            txtEa.Focus();
        }
        /// <summary>
        /// 수정 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEa.Text, out int ea))
            {
                bDao = new DAO.BomDAO();
                //부모 번호, 자식 번호, 자식 개수를 매개변수로 보냄
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

        /// <summary>
        /// 취소 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
