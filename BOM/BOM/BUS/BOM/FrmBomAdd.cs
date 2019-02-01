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
        DAO.BomDAO bDao;
        private int matNo;
        private int matLevel;
        private string matName;
        private bool canOrAdd; //Cancel인지 Add인지
        private Materials materials;

        public int MatNo { get => matNo; set => matNo = value; }
        public int MatLevel { get => matLevel; set => matLevel = value; }
        public string MatName { get => matName; set => matName = value; }
        public bool CanOrAdd { get => canOrAdd; set => canOrAdd = value; }
        

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
            FrmBomAllMatInfo fbami = new FrmBomAllMatInfo();
            fbami.Owner = this;
            fbami.ShowDialog();
            if (canOrAdd)
            {
                this.txtParentMatNo.Text = matNo.ToString();
                this.txtParentMatLevel.Text = matLevel.ToString();
                this.txtParentMatName.Text = matName; 
            }
        }

        private void btnMatSearch_Click(object sender, EventArgs e)
        {
            //모 품번이 없을 때
            if (string.IsNullOrEmpty(txtParentMatNo.Text))
            {
                MessageBox.Show("상위 품목을 먼저 설정해주세요.");
            }
            else
            {//level값보다 낮은 값만 
                int sendLevel = Int32.Parse(txtParentMatLevel.Text);
                int sendNo = Int32.Parse(txtParentMatNo.Text);
                FrmBomAllMatInfo fbami = new FrmBomAllMatInfo(sendLevel, sendNo);
                fbami.Owner = this;
                fbami.ShowDialog();
                if (canOrAdd)
                {
                    this.txtChildMatNo.Text = matNo.ToString();
                    this.txtChildMatLevel.Text = matLevel.ToString();
                    this.txtChildMatName.Text = matName; 
                }
            }
        }

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
                //BOM 등록을 바로 들어가는 경우
                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtParentMatNo.Text))
            {
                MessageBox.Show("모품목 번호를 입력해주세요!");
            }
            else if (string.IsNullOrEmpty(txtChildMatNo.Text))
            {
                MessageBox.Show("자품목 번호를 입력해주세요!");
            }
            else if (string.IsNullOrEmpty(txtChildMatEA.Text)) {
                MessageBox.Show("자품목의 개수를 입력해주세요!");
            }
            else
            {
                if (!int.TryParse(txtChildMatEA.Text,out int ea))
                {
                    MessageBox.Show("개수는 숫자값만 입력해주세요!");
                }
                else
                {
                    bDao = new DAO.BomDAO();
                    if (bDao.InsertBom(txtParentMatNo.Text, txtChildMatNo.Text, txtChildMatEA.Text))
                    {
                        MessageBox.Show("저장 성공!");
                    }
                    else
                    {
                        MessageBox.Show("저장 실패 : 데이터 중복 여부를 확인해주세요");
                    }
                }
            }
        }
    }
}
