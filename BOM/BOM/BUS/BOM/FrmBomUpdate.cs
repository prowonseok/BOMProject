﻿using System;
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
    /// <summary>
    /// BOM조회시 자식자재의 필요 갯수를 수정하기 위한 Form
    /// </summary>
    public partial class FrmBomUpdate : Form
    {
        MaterialsVO materials;
        DAO.BomDAO bDao;

        int ea;  //변경할 자재 개수를 닮을 변수
        int pNo; //변경할 자재임을 확인하기 위한 자재번호

        /// <summary>
        /// 수정할 자재에 대한 정보를 매개변수로 받아옴
        /// </summary>
        /// <param name="pNo">부모 자재 번호</param>
        /// <param name="materials">수정할 자재에 대한 정보</param>
        /// <param name="ea">기존 필요 자재 개수</param>
        public FrmBomUpdate(int pNo, MaterialsVO materials, int ea)
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
                //부모 번호, 자식 번호, 수정할 자식 개수를 매개변수로 보냄
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

        /// <summary>
        /// 수량 텍스트가 변경될때마다 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //입력된 값이 숫자, BackSpace키가 아닐 경우 입력 방지
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        
    }
}
