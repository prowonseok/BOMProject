using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        /// 메인화면에서 매개변수 없이 BOM화면 버튼 클릭 시 생성자
        /// </summary>
        public FrmBomAdd() {
            InitializeComponent();
        }
        
        /// <summary>
        /// 그리드뷰에서 BOM화면 버튼 클릭 시 생성자
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
                LevelChange(matLevel.ToString(), txtParentMatLevel);
                this.txtParentMatNo.Text = matNo.ToString();
                this.txtParentMatName.Text = matName;

                ViewTreeview();
            }
        }

        /// <summary>
        /// 숫자 Level(String형)을 입력하여 원재료, 반제품, 완제품으로 출력 변경하는 메서드
        /// </summary>
        /// <param name="level">입력하는 숫자 Level</param>
        /// <param name="textBox">값은 변경할 텍스트 박스</param>
        private void LevelChange(string level, TextBox textBox)
        {
            switch (level)
            {
                case "0":
                    textBox.Text = "원재료";
                    break;
                case "1":
                    textBox.Text = "반제품";
                    break;
                case "2":
                    textBox.Text = "완제품";
                    break;
                default:
                    break;
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
                int sendLevel = 0;
                switch (txtParentMatLevel.Text)
                {
                    case "완제품":
                        sendLevel = 2;
                        break;
                    case "반제품":
                        sendLevel = 1;
                        break;
                    case "원재료":
                        sendLevel = 0;
                        break;
                    default:
                        break;
                }
                int sendNo = Int32.Parse(txtParentMatNo.Text);
                FrmBomAllMatInfo fbami = new FrmBomAllMatInfo(sendLevel, sendNo);
                fbami.Owner = this; //FrmBomAllMatInfo Form에서 값을 받아오기 위해 Owner를 지정
                fbami.ShowDialog();
                //FrmBomAllMatInfo Form에서 등록인지 취소인지 판단
                if (canOrAdd)
                {
                    this.txtChildMatNo.Text = matNo.ToString();
                    LevelChange(matLevel.ToString(), txtChildMatLevel);
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
            this.BackColor=Color.White;
            try
            {
                //BOM 조회에서 등록으로 이동하는 경우
                txtParentMatNo.Text = materials.Mat_No.ToString();
                txtParentMatName.Text = materials.Mat_Name;
                LevelChange(materials.Mat_Level.ToString(), txtParentMatLevel);
                ViewTreeview();
            }
            catch (Exception)
            {
                //매개변수 값 없이 BOM등록 이동하는 경우
            }
        }

        /// <summary>
        /// 부모 자재에 대한 자식 자재들을 트리뷰로 출력
        /// </summary>
        private void ViewTreeview()
        {
            trvMat.Nodes.Clear();
            bDao = new DAO.BomDAO();
            TreeNode tNode = new TreeNode(txtParentMatName.Text);
            trvMat.Nodes.Add(tNode);
            //부모 자재명을 보내서 자식 자재와 필요 자재 개수를 출력
            DataTable dt = bDao.SelectChildTreeview(txtParentMatName.Text);
            //자식 자재들을 트리뷰의 tNode에 ChildNode로 추가
            foreach (DataRow item in dt.Rows)
            {
                TreeNode cNode = new TreeNode(item["Child_Name"].ToString() + " : " + Int32.Parse(item["BOM_ChildEA"].ToString()));
                tNode.Nodes.Add(cNode);
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
                            ViewTreeview();
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

        /// <summary>
        /// 수량 텍스트가 변경될때마다 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">입력된 값</param>
        private void txtChildMatEA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //입력된 값이 숫자, BackSpace키가 아닐 경우 입력 방지
            if (!(char.IsNumber(e.KeyChar)||e.KeyChar==Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
