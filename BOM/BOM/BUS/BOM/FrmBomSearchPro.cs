﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.BUS;
using BOM.VO;

namespace BOM
{
    /// <summary>
    /// 소요량예측 Form에서 소요량을 예측할 상품을 선택하기 위한 Form
    /// </summary>
    public partial class FrmBomSearchPro : Form
    {
        DAO.BomDAO bDao;
        Products products;

        /// <summary>
        /// 생성자
        /// </summary>
        public FrmBomSearchPro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form이 Load될 때 이벤트
        /// Products Table의 모든 데이터을 출력함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBomSearchPro_Load(object sender, EventArgs e)
        {
            bDao = new DAO.BomDAO();
            dgvProInfo.DataSource = bDao.SelectPro();
            DisplayGridview();
            dgvProInfo.Font= new Font("맑은고딕", 9);
        }

        /// <summary>
        /// 출력한 그리드뷰에 대해 설정하는 메서드
        /// </summary>
        private void DisplayGridview()
        {
            dgvProInfo.Columns.Remove("Pro_Spec");
            dgvProInfo.Columns.Remove("Pro_Img_No");
            dgvProInfo.Columns.Remove("Pro_ChangepriceDate");

            dgvProInfo.Columns[0].HeaderText = "제품 번호";
            dgvProInfo.Columns[1].HeaderText = "자재 번호";
            dgvProInfo.Columns[2].HeaderText = "제품 가격";
            dgvProInfo.Columns[2].DefaultCellStyle.Format = "###,###,###";
            dgvProInfo.Columns[3].HeaderText = "제품 명";

            dgvProInfo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProInfo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProInfo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvProInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// 적용 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            products = new Products();
            products.Pro_No = Int32.Parse(dgvProInfo.SelectedRows[0].Cells[0].Value.ToString());
            products.Mat_No = Int32.Parse(dgvProInfo.SelectedRows[0].Cells[1].Value.ToString());
            products.Pro_Price = Int32.Parse(dgvProInfo.SelectedRows[0].Cells[2].Value.ToString());
            products.Pro_Name = dgvProInfo.SelectedRows[0].Cells[3].Value.ToString();

            FrmBomMatEstimating fbme = (FrmBomMatEstimating)Owner;
            fbme.Products = this.products;
            fbme.CanOrAdd = true;
            this.Close();
        }
    }
}
