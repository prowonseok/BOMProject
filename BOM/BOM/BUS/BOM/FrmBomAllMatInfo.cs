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
    public partial class FrmBomAllMatInfo : Form
    {
        DAO.BomDAO bDao;
        int mat_Level=9999;//mat_Level의 값이 없을 때
        int mat_No;
        public FrmBomAllMatInfo(int mat_Level, int mat_No)
        {
            InitializeComponent();
            this.mat_Level = mat_Level;
            this.mat_No = mat_No;
        }
        public FrmBomAllMatInfo()
        {
            InitializeComponent();
        }

        private void FrmBomAllMatInfo_Load(object sender, EventArgs e)
        {
            if (mat_Level==9999)//모품목을 찾을 때
            {
                //모품목은 Level 0값은 뜨지 않도록 설정
                bDao = new DAO.BomDAO();
                dgvAllMat.DataSource = bDao.SelectBom2();
            }
            else //자품목을 찾을 때
            {
                //자품목은 모품목보다 Level값이 같거나 작은 값만 뜨도록 설정, 같은 품목은 안뜨도록
                bDao = new DAO.BomDAO();
                dgvAllMat.DataSource = bDao.SelectBom3(mat_Level, mat_No);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBomAdd fba = (FrmBomAdd)Owner;
            fba.MatNo = Int32.Parse(dgvAllMat.SelectedRows[0].Cells[0].Value.ToString());      //품목 번호
            fba.MatName = dgvAllMat.SelectedRows[0].Cells[3].Value.ToString();                 //품목 명
            fba.MatLevel = Int32.Parse(dgvAllMat.SelectedRows[0].Cells[5].Value.ToString());   //품목 레벨
            fba.CanOrAdd = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBomAdd fba = (FrmBomAdd)Owner;
            fba.CanOrAdd = false;
            this.Close();
        }
    }
}
