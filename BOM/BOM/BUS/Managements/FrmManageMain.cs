using BOM.DAO;
using BOM.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Managements
{
    public partial class FrmManageMain : Form
    {
        MatDAO md = new MatDAO();
        public FrmManageMain()
        {
            InitializeComponent();
        }

        private void FrmManageMain_Load(object sender, EventArgs e)
        {
            FormBuilder();
        }

        private void FormBuilder()
        {
            dgvMatList.DataSource = md.SelectMat("Materials_View_List_Select_Procedure");
            for (int i = 1; i < dgvMatList.Columns.Count; i++)
            {
                dgvMatList.Columns[i].ReadOnly = true;
            }
            dgvMatList.AllowUserToAddRows = false;

            foreach (DataGridViewRow rows in dgvMatList.Rows)
            {
                rows.Cells[0].Value = false;
            }

            dgvMatList.Columns[0].Width = 45;
            dgvMatList.Columns[1].Width = 80;
            dgvMatList.Columns[6].Width = 80;
        }

        private void dgvMatList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hitTestInfo;
                hitTestInfo = dgvMatList.HitTest(e.X, e.Y);

                int col = hitTestInfo.ColumnIndex;
                int row = hitTestInfo.RowIndex;

                if (col < 0) col = 0;
                if (row < 0) row = 0;

                dgvMatList.CurrentCell = dgvMatList[col, row];
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.Items.Add("수정");
                cms.Items.Add("삭제");
                cms.Items.Add("수량변경");

                cms.ItemClicked += new ToolStripItemClickedEventHandler(cms_ItemClicked);

                cms.Show(dgvMatList, new Point(e.X, e.Y));
            }
        }

        private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult dr;
            switch (e.ClickedItem.Text)
            {
                case "수정":
                    break;

                case "삭제":
                    bool checkVal = false;
                    foreach (DataGridViewRow rows in dgvMatList.Rows)
                    {
                        if ((bool)rows.Cells[0].Value == true)
                        {
                            checkVal = true;
                        }
                    }
                    if (checkVal == true)
                    {
                        List<int> chkList = new List<int>();
                        foreach (DataGridViewRow rows in dgvMatList.Rows)
                        {
                            if ((bool)rows.Cells[0].Value == true)
                            {
                                chkList.Add(int.Parse(rows.Cells[1].Value.ToString()));
                            }
                        }
                        dr = MessageBox.Show(chkList.Count.ToString() + "개의 행을 삭제하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.OK)
                        {
                            foreach (int item in chkList)
                            {
                                md.DeleteMat(item, item);
                            }
                        }
                    }
                    else if (checkVal == false)
                    {
                        dr = MessageBox.Show("자재 번호 " + dgvMatList.SelectedRows[0].Cells[1].Value.ToString() + " 자재명 " + dgvMatList.SelectedRows[0].Cells[2].Value.ToString() + " 을(를) 영구 삭제하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.OK)
                        {
                            md.DeleteMat(int.Parse(dgvMatList.SelectedRows[0].Cells[1].Value.ToString()), int.Parse(dgvMatList.SelectedRows[0].Cells[1].Value.ToString()));
                        }
                    }
                    Controls.Clear();
                    InitializeComponent();
                    FormBuilder();
                    break;
                case "수량변경":
                    break;
            }
        }

        private void btnMatAdd_Click(object sender, EventArgs e)
        {
            object[] listArray = new object[2];
            List<Materials_TypeVO> matTypeList = new List<Materials_TypeVO>();
            List<OffererVO> matOffererList = new List<OffererVO>();
            DataTable dtType = md.SelectMat("Materials_Type_Select_Procedure");
            DataTable dtOfferer = md.SelectMat("Offerer_Select_Procedure");
            foreach (DataRow item in dtType.Rows)
            {
                matTypeList.Add(new Materials_TypeVO(item["Mat_Type_No"].ToString(), item["Mat_Type_Category"].ToString()));
            }
            foreach (DataRow item in dtOfferer.Rows)
            {
                matOffererList.Add(new OffererVO(item["Off_No"].ToString(), item["Off_Name"].ToString()));
            }
            listArray[0] = matTypeList;
            listArray[1] = matOffererList;
            FrmMatAdd fma = new FrmMatAdd(md, listArray);
            fma.ShowDialog();


            //string openstrFilename;

            //openFileDialog1.Title = "이미지 읽기";
            //openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp|JPEG File(*.jpg)|*.jpg|Png(*.png)|*.png";

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    openstrFilename = openFileDialog1.FileName;
            //    Image image = Image.FromFile(openstrFilename);
            //    FileStream fs = new FileStream(openFileDialog1.FileNames[0], FileMode.OpenOrCreate, FileAccess.Read);

            //    System.Data.SqlClient.SqlParameter[] sqlParameter = new System.Data.SqlClient.SqlParameter[1];
            //    byte[] imageArr = new byte[fs.Length];
            //    fs.Read(imageArr, 0, Convert.ToInt32(fs.Length));
            //    sqlParameter[0] = new System.Data.SqlClient.SqlParameter("@pro_Img_Image", imageArr);

            //    fs.Close();

            //    dllPackager.DBProcessor dbp = new dllPackager.DBProcessor("Data Source=finalprojectbom.database.windows.net;Initial Catalog=FinalProject;User ID=finalproject;Password=Qwe123!@#");
            //    dbp.ExecuteParameters("Products_Image_Insert_Procedure", sqlParameter);
            //    MessageBox.Show("성공");
            //}
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrderMain fom = new FrmOrderMain();
            fom.ShowDialog();
        }

        private void btnProAdd_Click(object sender, EventArgs e)
        {
            FrmProducts fp = new FrmProducts();
            fp.ShowDialog();
        }
        
    }
}