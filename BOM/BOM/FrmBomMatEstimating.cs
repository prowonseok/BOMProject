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
        int haveNum=0; //가지고 있는 재고의 개수
        int makeNum=0; //만들고자 하는 재고의 개수

        List<int> numLst;
        DAO.BomDAO bDao;
        TreeNode tnode; //부모 노드로 돌아가기 위해 만드는 치환 노드

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


        private void CNode(DataTable dt2, TreeNode cNode, int num)
        {
            foreach (DataRow item2 in dt2.Rows)
            {
                //자식노드(DataTable의 DataRow)의 이름과 개수를 자식노드로 저장
                TreeNode chNode = new TreeNode(item2["Child_Name"].ToString() + " : " + Int32.Parse(item2["BOM_ChildEA"].ToString()) * num + " 개");
                cNode.Nodes.Add(chNode);

                //만약 자식노드가 존재한다면
                if (!string.IsNullOrEmpty(item2["Child_Name"].ToString()))
                {
                    if (bDao.Selectchildnode(item2["Child_Name"].ToString()))//자식노드가 그에 대한 자식노드를 가지고 있는지 판단
                    {
                        //tnode에 부모노드를 저장(다시 복귀할 때 부모노드를 찾아가기 위함)
                        tnode = cNode;
                        //자식노드였던 chNode를 부모노드인 cNode로 지정
                        cNode = chNode;
                        CNode(bDao.SelectChildTreeview(item2["Child_Name"].ToString()), cNode, num);
                        cNode = tnode;
                    }
                }
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
                        //3. 부모 자재명(바로 위의 자식 자재)을 입력받아서 BOM테이블과 JOIN 후 해당 자재를 부모로 가지고 있는 자식들의 자재명과 필요 개수를 DataTable에 저장
                        DataTable dt2 = bDao.SelectChildTreeview(item["Child_Name"].ToString());
                        //4. 부모노드와 자식노드 DataTable과 만들고자 하는 개수를 매개변수로 지정
                        //dt2 : 위의 자식노드를 부모로 하는 DataTable, cNode : 부모노드(위의 자식노드), num : 만들고자 하는 개수
                        CNode(dt2, cNode, num);
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
                    if (item.Cells[1].Value.ToString().Trim()== e.Node.Text.Substring(0, e.Node.Text.IndexOf(':')).Trim())
                    {
                        item.Selected = true;
                        haveNum = Int32.Parse(item.Cells[2].Value.ToString());
                        makeNum = Int32.Parse(e.Node.Text.Substring(e.Node.Text.IndexOf(':') + 1, e.Node.Text.Length - e.Node.Text.IndexOf(':') - 2));
                        if (haveNum / makeNum > 0)
                        {
                            lblEA.Text = haveNum / makeNum + "개";
                        }
                        else
                        {
                            lblEA.Text = "재고 부족";
                        }
                    }
                }
            }
            
            foreach (var item in matLst)
            {
                foreach (DataGridViewRow item2 in dgvMat.Rows)
                {
                    if (lblMatName.Text.Trim()==item2.Cells[1].Value.ToString().Trim())
                    {
                        item2.Selected = true;
                    }
                    if (item.Substring(0, item.IndexOf(':')).Trim() == item2.Cells[1].Value.ToString().Trim())
                    {
                        haveNum = Int32.Parse(item2.Cells[2].Value.ToString().Trim());
                        makeNum = Int32.Parse(item.Substring(item.IndexOf(':') + 1, item.Length - item.IndexOf(':') - 2));
                        if (Int32.Parse(item2.Cells[2].Value.ToString().Trim())>=Int32.Parse(item.Substring(item.IndexOf(':') + 1, item.Length - item.IndexOf(':') - 2)))
                        {
                            numLst.Add(haveNum / makeNum);
                        }
                        else
                        {
                            MessageBox.Show(item2.Cells[1].Value.ToString() + "재고 부족"+(makeNum-haveNum).ToString()+"개 필요");
                            numLst.Add(999999);
                        }
                        break;
                    }
                }
            }
            if (numLst.Count>0)
            {
                numLst.Sort();
                if (numLst[numLst.Count - 1] == 999999)
                {
                    lblEA.Text = "재고 부족";
                }
                else
                {
                    lblEA.Text = numLst[0].ToString();
                } 
            }
        }
        
    }
}

