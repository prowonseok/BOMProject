using BOM.DAO;
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
            FrmMatAdd fma = new FrmMatAdd();
            fma.ShowDialog();
        }
    }
}