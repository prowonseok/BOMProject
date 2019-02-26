using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.BUS.BOM;
using BOM.VO;

namespace BOM
{
    public partial class FrmBomDetailInfo : Form
    {
        DAO.BomDAO bDao;
        DataTable dt;
        DataTable dtClone;
        FrmBomInfo fbi;

        #region Property
        private int updateNum;
        private int matNo;
        private string matName;
        private bool canOrAdd; //Cancel인지 Add인지

        public int MatNo { get => matNo; set => matNo = value; }
        public string MatName { get => matName; set => matName = value; }
        public bool CanOrAdd { get => canOrAdd; set => canOrAdd = value; }
        public int UpdateNum { get => updateNum; set => updateNum = value; } 
        #endregion

        private MaterialsVO materials;

        /// <summary>
        /// 메인화면에서 매개변수 없이 BOM조회 버튼 클릭 시 생성자
        /// </summary>
        public FrmBomDetailInfo() {
            InitializeComponent();
        }

        /// <summary>
        /// 그리드뷰에서 BOM조회 버튼 클릭 시 생성자
        /// </summary>
        /// <param name="materials"></param>
        public FrmBomDetailInfo(MaterialsVO materials):this()
        {
            this.materials = materials;
        }

        /// <summary>
        /// Form이 Load될 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBomDetailInfo_Load(object sender, EventArgs e)
        {
            dgvBom.DataSource = null;
            try
            {
                //BOM조회 버튼을 클릭 했을 때 매개변수가 있었을 경우 BOM조회 페이지 화면에 매개변수로 받은 값들 출력
                if (!string.IsNullOrEmpty(materials.Mat_No.ToString()))//materials.Mat_No가 비어있지 않으면
                {
                    this.txtMatNo.Text = materials.Mat_No.ToString();
                    this.txtMatName.Text = materials.Mat_Name;
                }
            }
            //메인화면에서 매개변수 없이 BOM조회 버튼 클릭 시 발생하는 예외처리
            catch (NullReferenceException)
            {
            }
            dgvBom.AutoResizeColumns();
            rdoExplosion_CheckedChanged(null, null);

        }

        /// <summary>
        ///품목 찾기 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmBomSearchMat mbsm = new FrmBomSearchMat();
            mbsm.Owner = this; //FrmBomAllMatInfo Form에서 값을 받아오기 위해 Owner를 지정
            mbsm.ShowDialog();
            //FrmBomSearchMat Form에서 등록인지 취소인지 판단
            if (canOrAdd)
            {
                this.txtMatNo.Text = matNo.ToString();
                this.txtMatName.Text = matName.ToString();
            }
            dgvBom.DataSource = null;

            rdoExplosion_CheckedChanged(null, null);
        }

        /// <summary>
        /// RadioButton이 정전개시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoExplosion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExplosion.Checked) 
            {
                //수정 버튼과 삭제 버튼 활성화
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                //자재 번호의 값이 있을 경우
                if (!string.IsNullOrEmpty(txtMatNo.Text))
                {
                    bDao = new DAO.BomDAO();
                    //정전개시 자재 번호와 정전개 프로시저를 매개변수로 전송
                    dt = bDao.SelectBom(Int32.Parse(txtMatNo.Text), "Bom_Bom_Explosion_Procedure");
                    fbi = new FrmBomInfo();
                    dgvBom.DataSource = fbi.CloneDataTable(dt, dtClone);
                    DisplayGridview(true); //그리드뷰 셋팅을 정전개와 역전개를 다르게 하기 위해 bool타입 변수를 매개변수로 전송
                }
            }
        }

        /// <summary>
        /// RadioButton이 역전개시 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoImplosion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoImplosion.Checked) 
            {
                //수정 버튼과 삭제 버튼 비활성화
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                //자재 번호의 값이 있을 경우
                if (!string.IsNullOrEmpty(txtMatNo.Text))
                {
                    bDao = new DAO.BomDAO();
                    //역전개시 자재 번호와 역전개 프로시저를 매개변수로 전송
                    dt= bDao.SelectBom(Int32.Parse(txtMatNo.Text), "Bom_Bom_Implosion_Procedure");
                    fbi = new FrmBomInfo();
                    dgvBom.DataSource = fbi.CloneDataTable(dt, dtClone);
                    DisplayGridview(false); //그리드뷰 셋팅을 정전개와 역전개를 다르게 하기 위해 bool타입 변수를 매개변수로 전송
                }
            }
        }

        /// <summary>
        /// 출력한 그리드뷰에 대해 설정하는 메서드
        /// </summary>
        /// <param name="type"></param>
        private void DisplayGridview(bool type)
        {
            if (type)
            {   //정전개시
                if (dgvBom.Columns.Count >= 1)
                {
                    dgvBom.Columns[0].HeaderText = "자재번호";
                    dgvBom.Columns[1].HeaderText = "자재명";
                    dgvBom.Columns[2].HeaderText = "가격(원)";
                    dgvBom.Columns[2].DefaultCellStyle.Format = "###,###,###";
                    dgvBom.Columns[3].HeaderText = "자재 레벨";
                    dgvBom.Columns[4].HeaderText = "자재 개수";

                    dgvBom.AutoResizeColumns();

                    dgvBom.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvBom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                //역전개시
                if (dgvBom.Columns.Count >= 1)
                {
                    dgvBom.Columns.RemoveAt(7);
                    dgvBom.Columns.RemoveAt(6);
                    dgvBom.Columns.RemoveAt(2);
                    dgvBom.Columns.RemoveAt(1);


                    dgvBom.Columns[0].HeaderText = "자재번호";
                    dgvBom.Columns[1].HeaderText = "자재명";
                    dgvBom.Columns[2].HeaderText = "가격(원)";
                    dgvBom.Columns[2].DefaultCellStyle.Format = "###,###,###";
                    dgvBom.Columns[3].HeaderText = "자재 레벨";
                    dgvBom.AutoResizeColumns();

                    dgvBom.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvBom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        /// <summary>
        /// 수정 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //해당 자재의 자식 자재 갯수를 수정하기 위한 이벤트
            try
            {
                dgvBom.SelectedRows[0].Cells[1].Value.ToString();
                FrmBomUpdate fbu = new FrmBomUpdate(Int32.Parse(txtMatNo.Text), 
                    new MaterialsVO
                    {
                    Mat_No = Int32.Parse(dgvBom.SelectedRows[0].Cells[0].Value.ToString()),
                    Mat_Name= dgvBom.SelectedRows[0].Cells[1].Value.ToString()
                }, Int32.Parse(dgvBom.SelectedRows[0].Cells[4].Value.ToString()));
                fbu.Owner = this;
                fbu.ShowDialog();

                rdoExplosion_CheckedChanged(null,null);
            }
            catch (Exception)
            {
                MessageBox.Show("수정 할 데이터가 지정되지 않았습니다.");
            }
        }

        /// <summary>
        /// 삭제 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBom.SelectedRows[0].Cells[1].Value.ToString();
                var result = MessageBox.Show("정말 삭제하시겠습니까? ", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bDao = new DAO.BomDAO();
                    if (bDao.DeleteBom(Int32.Parse(txtMatNo.Text), Int32.Parse(dgvBom.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("삭제되었습니다.");
                        rdoExplosion_CheckedChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패 하였습니다.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("삭제할 데이터가 지정되지 않았습니다.");
            }

        }
    }
}
