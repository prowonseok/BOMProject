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
            tvProMat.Nodes.Clear();
            FrmBomSearchPro fbsp = new FrmBomSearchPro();
            fbsp.Owner = this;
            fbsp.ShowDialog();

            if (canOrAdd)
            {
                this.txtPName.Text = products.Pro_Name.ToString();
            }

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
                    TreeNode cNode = new TreeNode(item["Child_Name"].ToString() + " : " + item["BOM_ChildEA"].ToString() + " 개");
                    pNode.Nodes.Add(cNode);
                    //여기서 하면 될 거 같은딩

                    DataTable dt2 = bDao.SelectChildTreeview(item["Child_Name"].ToString());
                    CNode(dt2, cNode);

                }
            }
        }

        private void CNode(DataTable dt2, TreeNode cNode)
        {
            foreach (DataRow item2 in dt2.Rows)
            {
                TreeNode chNode = new TreeNode(item2["Child_Name"].ToString() + " : " + item2["BOM_ChildEA"].ToString() + " 개");
                cNode.Nodes.Add(chNode); 

                if (!string.IsNullOrEmpty(item2["Child_Name"].ToString()))
                {
                    if (bDao.Selectchildnode(item2["Child_Name"].ToString()))//if 자식노드가 자식노드를 가지고 있을 때
                    {
                        tnode = cNode;
                        cNode = chNode;
                        CNode(bDao.SelectChildTreeview(item2["Child_Name"].ToString()), cNode);
                        cNode = tnode;
                    }
                }
            }
        }

        private void btnSearchTree_Click(object sender, EventArgs e)
        {

        }
    }
}

