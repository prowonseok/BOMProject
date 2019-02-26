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
using System.Xml;
using BOM.VO;

namespace BOM
{
    public partial class FrmBomMatEstimating : Form
    {
        private int haveNum = 0; //가지고 있는 재고의 개수
        private int makeNum = 0; //만들고자 하는 재고의 개수

        List<int> numLst;
        DAO.BomDAO bDao;

        private XmlTextWriter xr;

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
            //숫자만 입력 받기 위한 If문
            if (!string.IsNullOrEmpty(txtEA.Text) && int.TryParse(txtEA.Text, out int num))
            {
                //제품 선택이 되어야 입력받음
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
                        TreeNode cNode = new TreeNode(item["Child_Name"].ToString() + "...." + Int32.Parse(item["BOM_ChildEA"].ToString()) * num + "EA");
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
                TreeNode chNode = new TreeNode(item2["Child_Name"].ToString() + "...." + Int32.Parse(item2["BOM_ChildEA"].ToString()) * num + "EA");
                cNode.Nodes.Add(chNode);
                SubTreeview(num, item2, chNode);
            }
        }

        /// <summary>
        /// 출력한 그리드뷰에 대해 설정하는 메서드
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
        /// 자식 노드에 형제노드가 있을 경우 없을때까지 matLst에 추가
        /// </summary>
        /// <param name="matLst">선택한 노드의 자식노드들을 저장하는 리스트</param>
        /// <param name="nextNode">자식노드의 다음 형제노드</param>
        private void AddNextNode(List<string> matLst, TreeNode nextNode)
        {
            matLst.Add(nextNode.Text);
            try
            {
                AddNextNode(matLst, nextNode.NextNode);
            }
            catch (Exception)
            {
                
            }
        }

        /// <summary>
        /// 자재별 소요량 예측을 위한 더블 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">소요량 예측을 위해 더블클릭한 노드</param>
        private void tvProMat_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            numLst = new List<int>();                 //재고들을 저장할 Collection
            List<string> matLst = new List<string>(); //선택 노드 자식노드들을 저장할 Collection

            if (e.Node.Text.Contains('.'))
            {
                lblMatName.Text = e.Node.Text.Substring(0, e.Node.Text.IndexOf('.'));
            }
            else
            {
                lblMatName.Text = e.Node.Text;
            }
            try
            {
                matLst.Add(e.Node.FirstNode.Text);               //첫번째 자식노드를 matLst에 저장
                AddNextNode(matLst, e.Node.FirstNode.NextNode);  //그 후에 자식노드가 형제노드를 가지고 있다면 추가적으로 저장
            }
            catch (NullReferenceException)
            {
                //선택한 노드가 자식노드를 가지고 있지 않은 경우(AddNextNode에서 예외처리 되지 않고 matLst.Add에서 예외처리 된 경우)
                foreach (DataGridViewRow item in dgvMat.Rows)
                {
                    if (item.Cells[1].Value.ToString().Trim() == e.Node.Text.Substring(0, e.Node.Text.IndexOf('.')).Trim()) //GridView의 자재명과 선택한 노드의 명이 같을 때
                    {
                        item.Selected = true;  //해당 항목을 Selected True 처리
                        haveNum = Int32.Parse(item.Cells[2].Value.ToString());  //GridView를 참조하고 가지고 있는 개수를 haveNum변수에 저장
                        makeNum = Int32.Parse(e.Node.Text.Substring(e.Node.Text.LastIndexOf('.') + 1, e.Node.Text.Length - e.Node.Text.LastIndexOf('E') - 1)); //만들고자 하는 개수를 makeNum변수에 저장--
                        if (haveNum / makeNum > 0)
                        {
                            MessageBox.Show(e.Node.ToString()+ "은 \r\n현재 재고로" + haveNum / makeNum + "개 만들 수 있습니다.");
                        }
                        else
                        {
                            MessageBox.Show("재고가 부족합니다.");
                        }
                    }
                }
            }

            //AddNextNode에서 예외처리 되어 matLst에 자식노드들이 저장되어 있는 경우
            foreach (var item in matLst)
            {
                foreach (DataGridViewRow item2 in dgvMat.Rows)
                {
                    if (lblMatName.Text.Trim() == item2.Cells[1].Value.ToString().Trim())
                    {
                        item2.Selected = true;
                    }
                    if (item.Substring(0, item.IndexOf('.')).Trim() == item2.Cells[1].Value.ToString().Trim())
                    {
                        haveNum = Int32.Parse(item2.Cells[2].Value.ToString().Trim()); //현재 재고
                        makeNum = Int32.Parse(item.Substring(item.LastIndexOf('.') + 1, item.Length - item.LastIndexOf('E') - 1));
                        if (Int32.Parse(item2.Cells[2].Value.ToString().Trim()) >= Int32.Parse(item.Substring(item.LastIndexOf('.')+1 , item.Length - item.LastIndexOf('E') -1)))
                        {
                            numLst.Add(haveNum / makeNum); //만들수 있는 개수를 numLst에 저장
                        }
                        else
                        {
                            MessageBox.Show(item2.Cells[1].Value.ToString() + "재고 부족" + (makeNum - haveNum).ToString() + "개 필요");
                            numLst.Add(999999); //재고가 부족할 경우 numLst에 999999를 저장
                        }
                        break;
                    }
                }
            }
            if (numLst.Count > 0)
            {
                numLst.Sort(); //numLst를 오름차순으로 정렬(numLst의 최후 값이 999999인지 빠른 비교와 첫번째 값이 만들 수 있는 개수)
                if (numLst[numLst.Count - 1] == 999999) //재고 부족이 있는 경우
                {
                    
                }
                else                                    //재고 부족이 없는 경우
                {
                    MessageBox.Show(e.Node.Text + "은 \r\n현재 재고로" + numLst[0].ToString() + "개 만들 수 있습니다.");
                }
            }
        }

        /// <summary>
        /// Xml파일로 저장 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e)
        {
            //트리뷰가 비어있지 않을 경우만
            if (tvProMat.Nodes.Count!=0)
            {
                xr = new XmlTextWriter(@"C:\Users\gd19\Desktop\This\MyP2c.xml", Encoding.UTF8);
                xr.WriteStartDocument();

                xr.WriteStartElement(tvProMat.Nodes[0].Text.Replace(' ', '_')); //공백을 _으로 변경 후 저장

                //Treeview의 Nodes을 저장
                foreach (TreeNode item in tvProMat.Nodes)
                {
                    WriteChildNodeXml(item.Nodes);
                }

                xr.WriteEndElement();
                xr.Flush();
                xr.Close(); 
            }
        }

        /// <summary>
        /// Treeview의 node를 받아서 XmlTextWriter에 입력하는 재귀함수
        /// </summary>
        /// <param name="nodes"></param>
        private void WriteChildNodeXml(TreeNodeCollection nodes)
        {
            foreach (TreeNode item in nodes)
            {
                //자식이 있을 경우
                if (item.Nodes.Count > 0)
                {
                    xr.WriteStartElement(item.Text.Replace(' ','_'));
                    xr.WriteRaw("\r\n\n");
                    WriteChildNodeXml(item.Nodes);
                    xr.WriteEndElement();
                }//자식이 없을 경우
                else
                {
                    xr.WriteString(item.Text.Replace(' ','_'));
                }
            }
        }
    }
}

