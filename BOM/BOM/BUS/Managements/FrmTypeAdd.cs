using BOM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Managements
{
    public partial class FrmTypeAdd : Form
    {
        MatDAO mDAO = new MatDAO();
        DataTable dt = new DataTable();
        public FrmTypeAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼 로드 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTypeAdd_Load(object sender, EventArgs e)
        {
            tbTypeNo.ImeMode = ImeMode.Alpha;
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Button")
                {
                    ((Button)item).BackColor = Color.Silver;
                    ((Button)item).ForeColor = Color.White;
                }
            }
            dt = mDAO.SelectMatType();
            dgvMatTypeList.DataSource = dt;
            dgvMatTypeList.Font = new Font("맑은고딕", 9, FontStyle.Bold);
            dgvMatTypeList.AllowUserToAddRows = false;
            dgvMatTypeList.Columns[0].HeaderText = "분류 번호";
            dgvMatTypeList.Columns[1].HeaderText = "분류명";
        }

        /// <summary>
        /// 등록 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tbTypeNo.Text) || string.IsNullOrEmpty(tbTypeCate.Text)))
            {
                try
                {
                    DialogResult dr = MessageBox.Show("분류 번호 : " + tbTypeNo.Text + "\n분류명 : " + tbTypeCate.Text + "\n등록하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        mDAO.InsertMatType(tbTypeNo.Text, tbTypeCate.Text);
                        MessageBox.Show("등록 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("다음의 사유로 등록 실패\n" + exc.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("모든 사항을 입력하여 주십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// 번호 텍스트박스 KeyPress 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTypeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string stringValidator = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string fKeySet = Convert.ToString(Keys.Back) + Convert.ToString(Keys.Shift) + Convert.ToString(Keys.Control) + Convert.ToString(Keys.Alt) + Convert.ToString(Keys.Tab) + Convert.ToString(Keys.Escape) + Convert.ToString(Keys.LWin) + Convert.ToString(Keys.RWin);
            ////char[] keyCharArray = { Convert.ToChar(Keys.Back), Convert.ToChar(Keys.Shift), Convert.ToChar(Keys.Control), Convert.ToChar(Keys.Alt), Convert.ToChar(Keys.Tab), Convert.ToChar(Keys.Escape), Convert.ToChar(Keys.LWin), Convert.ToChar(Keys.RWin) };
            ////string fKeySet = new string(keyCharArray);
            //if (!(stringValidator.Contains(e.KeyChar.ToString()) || fKeySet.Contains(e.KeyChar.ToString())))
            //{
            //    e.Handled = true;
            //}

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
