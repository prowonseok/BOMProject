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

namespace BOM.BUS.BOM
{
    public partial class FrmBomAdd : Form
    {
        DAO.BomDAO bDao;

        #region Property
        private int matNo;
        private int matLevel;
        private string matName;
        private bool canOrAdd; //Cancel인지 Add인지
        private MaterialsVO materials;

        public int MatNo { get => matNo; set => matNo = value; }
        public int MatLevel { get => matLevel; set => matLevel = value; }
        public string MatName { get => matName; set => matName = value; }
        public bool CanOrAdd { get => canOrAdd; set => canOrAdd = value; } 
        #endregion

        /// <summary>
        /// 메인화면에서 매개변수 없이 BOM화면 버튼 클릭 시
        /// </summary>
        public FrmBomAdd() {
            InitializeComponent();
        }
        
        /// <summary>
        /// 그리드뷰에서 BOM화면 버튼 클릭 시
        /// </summary>
        /// <param name="materials">부모 자재가 될 자재</param>
        public FrmBomAdd(MaterialsVO materials) : this()
        {
            this.materials = materials;
        }

        /// <summary>
        /// 부모자재 찾기 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPMatSearch_Click(object sender, EventArgs e)
        {
            FrmBomAllMatInfo fbami = new FrmBomAllMatInfo();
            fbami.Owner = this; //FrmBomAllMatInfo Form에서 값을 받아오기 위해 Owner를 지정
            fbami.ShowDialog();
            //FrmBomAllMatInfo Form에서 등록인지 취소인지 판단
            if (canOrAdd)
            {
                this.txtParentMatNo.Text = matNo.ToString();
                this.txtParentMatLevel.Text = matLevel.ToString();
                this.txtParentMatName.Text = matName; 
            }
        }

        /// <summary>
        /// 자식자재 찾기 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatSearch_Click(object sender, EventArgs e)
        {
            //모자재가 없을 때
            if (string.IsNullOrEmpty(txtParentMatNo.Text))
            {
                MessageBox.Show("상위 품목을 먼저 설정해주세요.");
            }
            else
            {   //모자재의 Level 값보다 낮은 Level의 값만 불러오기 위해 Level값도 매개변수로 지정
                int sendLevel = Int32.Parse(txtParentMatLevel.Text);
                int sendNo = Int32.Parse(txtParentMatNo.Text);
                FrmBomAllMatInfo fbami = new FrmBomAllMatInfo(sendLevel, sendNo);
                fbami.Owner = this; //FrmBomAllMatInfo Form에서 값을 받아오기 위해 Owner를 지정
                fbami.ShowDialog();
                //FrmBomAllMatInfo Form에서 등록인지 취소인지 판단
                if (canOrAdd)
                {
                    this.txtChildMatNo.Text = matNo.ToString();
                    this.txtChildMatLevel.Text = matLevel.ToString();
                    this.txtChildMatName.Text = matName; 
                }
            }
        }

        /// <summary>
        /// Form이 Load될 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBomAdd_Load(object sender, EventArgs e)
        {
            try
            {
                //BOM 조회에서 등록으로 이동하는 경우
                txtParentMatNo.Text = materials.Mat_No.ToString();
                txtParentMatName.Text = materials.Mat_Name;
                txtParentMatLevel.Text = materials.Mat_Level.ToString();
            }
            catch (Exception)
            {
                //매개변수 값 없이 BOM등록 이동하는 경우
                
            }

        }

        /// <summary>
        /// 등록 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //부모 자재 번호가 등록되지 않았을 때
            if (string.IsNullOrEmpty(txtParentMatNo.Text))
            {
                MessageBox.Show("부모 자재 번호를 입력해주세요!");
            }
            //자식 자재 번호가 등록되지 않았을 때
            else if (string.IsNullOrEmpty(txtChildMatNo.Text))
            {
                MessageBox.Show("자식 자재 번호를 입력해주세요!");
            }
            //자식 자재 필요 개수가 입력되지 않았을 때 
            else if (string.IsNullOrEmpty(txtChildMatEA.Text)) {
                MessageBox.Show("자식 자재의 개수를 입력해주세요!");
            }
            else
            {
                //자식 자재 필요 개수에 숫자가 아닌 값이 입력되거나 0보다 작은 수가 입력 될 경우
                if (!int.TryParse(txtChildMatEA.Text,out int ea)||ea<0)
                {
                    MessageBox.Show("개수는 올바른 숫자값만 입력해주세요!");
                }
                else
                {
                    //부모 자재와 자식 자재의 값이 같을 경우
                    if (txtParentMatNo.Text==txtChildMatNo.Text)
                    {
                        MessageBox.Show("모품목과 자품목이 같은 품목이면 등록될 수 없습니다!");
                    }
                    else
                    {
                        //모든 입력이 정상적일 경우
                        bDao = new DAO.BomDAO();
                        if (bDao.InsertBom(txtParentMatNo.Text, txtChildMatNo.Text, txtChildMatEA.Text))
                        {
                            MessageBox.Show("저장 성공!");
                            txtChildMatNo.Text = txtChildMatName.Text = txtChildMatLevel.Text = txtChildMatEA.Text = null;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("저장 실패 : 데이터 중복 여부를 확인해주세요");
                        } 
                    }
                }
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
