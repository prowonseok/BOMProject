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
    public partial class FrmBomMatEstimating : Form
    {
        int haveNum = 0; //가지고 있는 재고의 개수
        int makeNum = 0; //만들고자 하는 재고의 개수

        List<int> numLst;
        DAO.BomDAO bDao;

        #region Property
        private Products products;
        private bool canOrAdd;
        internal Products Products { get => products; set => products = value; }
        public bool CanOrAdd { get => canOrAdd; set => canOrAdd = value; }
        #endregion

        /// <summary>
        /// 생성자
        /// </summary>
        public FrmBomMatEstimating()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 제품 찾기 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchPro_Click(object sender, EventArgs e)
        {
            FrmBomSearchPro fbsp = new FrmBomSearchPro();
            fbsp.Owner = this;
            fbsp.ShowDialog();

            if (canOrAdd)
            {
                this.txtPName.Text = products.Pro_Name.ToString();
            }
        }
        
        /// <summary>
        /// 검색 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchTree_Click(object sender, EventArgs e)
        {
            tvProMat.Nodes.Clear();
            if (!string.IsNullOrEmpty(txtEA.Text) && int.TryParse(txtEA.Text, out int num))
            {
                if (!string.IsNullOrEmpty(this.txtPName.Text))
                {
                    bDao = new DAO.BomDAO();

                    DataTable dt = bDao.SelectTreeview(Products.Pro_No);

                    TreeNode pNode = new TreeNode();

                    foreach (DataRow item in dt.Rows)
                    {
                        //1. 최초 제품명을 부모 노드로 설정
                        pNode = new TreeNode(item["Mat_Name"].ToString());
                        tvProMat.Nodes.Add(pNode);
                        break;
                    }
                    foreach (DataRow item in dt.Rows)
                    {
                        //2. DataTable에서 부모의 Child_Name과 Child_EA를 자식 노드로 저장
                        TreeNode cNode = new TreeNode(item["Child_Name"].ToString() + " : " + Int32.Parse(item["BOM_ChildEA"].ToString()) * num + "개");
                        pNode.Nodes.Add(cNode);
                        //자식노드의 자식노드 등록
                        DataTable dt2 = bDao.SelectChildTreeview(item["Child_Name"].ToString());
                        
                        SubTreeview(num, item, cNode);
                    }

                    dgvMat.DataSource = bDao.SelectBom();
                    DisplayGridview();
                }
                else
                {
                    MessageBox.Show("제품을 선택해주세요");
                }
            }
            else
            {
                MessageBox.Show("수량을 적어주세요");
            }
        }

        /// <summary>
        /// 자식 노드가 있을 시 자식노드를 트리뷰에 추가하는 재귀메서드
        /// </summary>
        /// <param name="num">원하는 자재 개수</param>
        /// <param name="item">부모 자재명을 가지고 있는 DataRow</param>
        /// <param name="cNode">부모 자재가 될 노드</param>
        private void SubTreeview(int num, DataRow item, TreeNode cNode)
        {
            DataTable dt2 = bDao.SelectChildTreeview(item["Child_Name"].ToString());
            foreach (DataRow item2 in dt2.Rows)
            {
                TreeNode chNode = new TreeNode(item2["Child_Name"].ToString() + " : " + Int32.Parse(item2["BOM_ChildEA"].ToString()) * num + "개");
                cNode.Nodes.Add(chNode);
                SubTreeview(num, item2, chNode);
            }
        }

        /// <summary>
        /// 그리드뷰 설정 메서드
        /// </summary>
        private void DisplayGridview()
        {
            dgvMat.Columns.RemoveAt(7);
            dgvMat.Columns.RemoveAt(5);
            dgvMat.Columns.RemoveAt(4);
            dgvMat.Columns.RemoveAt(2);
            dgvMat.Columns.RemoveAt(1);
            dgvMat.Columns[0].HeaderText = "자재 번호";
            dgvMat.Columns[1].HeaderText = "자재 명";
            dgvMat.Columns[2].HeaderText = "개수";
            dgvMat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// 자재별 소요량 예측을 위한 더블 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">소요량 예측을 위해 더블클릭한 노드</param>
        private void tvProMat_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            numLst = new List<int>();
            List<string> matLst = new List<string>();
            if (e.Node.Text.Contains(':'))
            {
                lblMatName.Text = e.Node.Text.Substring(0, e.Node.Text.IndexOf(':'));
            }
            else
            {
                lblMatName.Text = e.Node.Text;
            }
            try
            {
                matLst.Add(e.Node.FirstNode.Text);
                while (true)
                {
                    try
                    {
                        matLst.Add(e.Node.FirstNode.NextNode.Text);
                        matLst.Add(e.Node.FirstNode.NextNode.NextNode.Text);
                        matLst.Add(e.Node.FirstNode.NextNode.NextNode.NextNode.Text);
                        matLst.Add(e.Node.FirstNode.NextNode.NextNode.NextNode.NextNode.Text);
                        matLst.Add(e.Node.FirstNode.NextNode.NextNode.NextNode.NextNode.NextNode.Text);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }

            }
            catch (Exception)
            {
                foreach (DataGridViewRow item in dgvMat.Rows)
                {
                    if (item.Cells[1].Value.ToString().Trim() == e.Node.Text.Substring(0, e.Node.Text.IndexOf(':')).Trim())
                    {
                        item.Selected = true;
                        haveNum = Int32.Parse(item.Cells[2].Value.ToString());
                        makeNum = Int32.Parse(e.Node.Text.Substring(e.Node.Text.IndexOf(':') + 1, e.Node.Text.Length - e.Node.Text.IndexOf(':') - 2));
                        if (haveNum / makeNum > 0)
                        {
                            MessageBox.Show(e.Node.ToString()+"\r\n"+ haveNum / makeNum + "개");
                        }
                        else
                        {
                            MessageBox.Show("재고가 부족합니다.");
                        }
                    }
                }
            }

            foreach (var item in matLst)
            {
                foreach (DataGridViewRow item2 in dgvMat.Rows)
                {
                    if (lblMatName.Text.Trim() == item2.Cells[1].Value.ToString().Trim())
                    {
                        item2.Selected = true;
                    }
                    if (item.Substring(0, item.IndexOf(':')).Trim() == item2.Cells[1].Value.ToString().Trim())
                    {
                        haveNum = Int32.Parse(item2.Cells[2].Value.ToString().Trim());
                        makeNum = Int32.Parse(item.Substring(item.IndexOf(':') + 1, item.Length - item.IndexOf(':') - 2));
                        if (Int32.Parse(item2.Cells[2].Value.ToString().Trim()) >= Int32.Parse(item.Substring(item.IndexOf(':') + 1, item.Length - item.IndexOf(':') - 2)))
                        {
                            numLst.Add(haveNum / makeNum);
                        }
                        else
                        {
                            MessageBox.Show(item2.Cells[1].Value.ToString() + "재고 부족" + (makeNum - haveNum).ToString() + "개 필요");
                            numLst.Add(999999);
                        }
                        break;
                    }
                }
            }
            if (numLst.Count > 0)
            {
                numLst.Sort();
                if (numLst[numLst.Count - 1] == 999999)
                {
                    MessageBox.Show("재고 부족");
                }
                else
                {
                    MessageBox.Show(e.Node.Text + "은 \r\n 현재 재고로" + numLst[0].ToString() + "개 만들 수 있습니다.");
                }
            }
        }

    }
}

