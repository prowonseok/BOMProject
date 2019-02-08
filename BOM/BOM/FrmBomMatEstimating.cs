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
        DAO.BomDAO bDao;
        TreeNode tnode;
        private Products products;
        private bool canOrAdd;
        internal Products Products { get => products; set => products = value; }
        public bool CanOrAdd { get => canOrAdd; set => canOrAdd = value; }

        public FrmBomMatEstimating()
        {
            InitializeComponent();
        }

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
                TreeNode chNode = new TreeNode(item2["Child_Name"].ToString() + " : " + Int32.Parse(item2["BOM_ChildEA"].ToString()) * num + " 개");
                cNode.Nodes.Add(chNode);

                if (!string.IsNullOrEmpty(item2["Child_Name"].ToString()))
                {
                    if (bDao.Selectchildnode(item2["Child_Name"].ToString()))//if 자식노드가 자식노드를 가지고 있을 때
                    {
                        tnode = cNode;
                        cNode = chNode;
                        CNode(bDao.SelectChildTreeview(item2["Child_Name"].ToString()), cNode, num);
                        cNode = tnode;
                    }
                }
            }
        }

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
                        pNode = new TreeNode(item["Mat_Name"].ToString());
                        tvProMat.Nodes.Add(pNode);
                        break;
                    }
                    foreach (DataRow item in dt.Rows)
                    {
                        TreeNode cNode = new TreeNode(item["Child_Name"].ToString() + " : " + Int32.Parse(item["BOM_ChildEA"].ToString()) * num + " 개");
                        pNode.Nodes.Add(cNode);
                        //여기서 하면 될 거 같은딩

                        DataTable dt2 = bDao.SelectChildTreeview(item["Child_Name"].ToString());
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

        private void tvProMat_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
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
                throw;
            }

            foreach (var item in matLst)
            {
                //MessageBox.Show(item);
                foreach (DataGridViewRow item2 in dgvMat.Rows)
                {
                    MessageBox.Show(item.Substring(0, e.Node.Text.IndexOf(':')-1).Trim()+",   "+ item2.Cells[1].Value.ToString().Trim());
                    if (item.Substring(0, e.Node.Text.IndexOf(':')).Trim() == item2.Cells[1].Value.ToString().Trim())
                    {
                        MessageBox.Show(item2.Cells[2].Value.ToString());
                        break;
                    }
                }
                
            }
        }
    }
}

