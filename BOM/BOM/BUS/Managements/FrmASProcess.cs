using BOM.BUS.Managements.Controls;
using BOM.DAO;
using BOM.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Managements
{
    public partial class FrmASProcess : Form
    {
        int asNo;
        int matNo;
        int offNo;
        MatDAO mdao = new MatDAO();
        OfferOrderDAO ood = new OfferOrderDAO();
        List<OffererOrderViewVO> oovList = new List<OffererOrderViewVO>();
        List<OrderInfo> asList = new List<OrderInfo>();

        public FrmASProcess(int asNo)
        {
            InitializeComponent();
            this.asNo = asNo;
        }

        private void FrmASProcess_Load(object sender, EventArgs e)
        {
            DGVBuilder();
            DataTable dt = ood.SelectOrder();
            foreach (DataRow item in dt.Rows)
            {
                if (int.Parse(item["Mat_Level"].ToString()) == 1)
                {
                    oovList.Add(new OffererOrderViewVO(int.Parse(item["Mat_No"].ToString()), int.Parse(item["Off_No"].ToString()), item["Mat_Name"].ToString(), int.Parse(item["Mat_Level"].ToString()), item["Off_Name"].ToString(), int.Parse(item["Mat_Cost"].ToString())));
                }
            }
            foreach (OffererOrderViewVO item in oovList)
            {
                if (item.Mat_Level == 1)
                {
                    cbName.Items.Add(item.Mat_Name);
                }
            }
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Button")
                {
                    ((Button)item).BackColor = Color.Silver;
                    ((Button)item).ForeColor = Color.White;
                }
            }
        }

        private void DGVBuilder()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = asList;
            dgvOrder.Columns[0].HeaderText = "자재번호";
            dgvOrder.Columns[1].HeaderText = "자재명";
            dgvOrder.Columns[2].HeaderText = "제조사 번호";
            dgvOrder.Columns[3].HeaderText = "제조사";
            dgvOrder.Columns[4].HeaderText = "단가";
            dgvOrder.Columns[5].HeaderText = "수량";
            dgvOrder.Columns[6].HeaderText = "합계";

            dgvOrder.Columns[0].Width = 60;
            dgvOrder.Columns[1].Width = 70;
            dgvOrder.Columns[2].Width = 70;
            dgvOrder.Columns[3].Width = 70;
            dgvOrder.Columns[4].Width = 60;
            dgvOrder.Columns[5].Width = 60;
            dgvOrder.Columns[6].Width = 60;
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < oovList.Count; i++)
            {
                if (cbName.SelectedIndex == i)
                {
                    matNo = oovList[i].Mat_No;
                    offNo = oovList[i].Off_No;
                    tbOfferer.Text = oovList[i].Off_Name;
                    tbCost.Text = oovList[i].Mat_Cost.ToString();
                }
            }
            nudEA.Value = 0;
        }

        private void nudEA_ValueChanged(object sender, EventArgs e)
        {
            if (!(cbName.SelectedIndex == -1))
            {
                tbTotalCost.Text = (int.Parse(tbCost.Text) * nudEA.Value).ToString();
            }
            else if (cbName.SelectedIndex == -1)
            {
                nudEA.Value = 0;
                MessageBox.Show("자재를 선택하여 주십시오");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudEA.Value != 0)
            {
                asList.Add(new OrderInfo(matNo, cbName.Text, oovList[cbName.SelectedIndex].Off_No, tbOfferer.Text, int.Parse(tbCost.Text), int.Parse(nudEA.Value.ToString()), int.Parse(tbTotalCost.Text)));
            }
            DGVBuilder();
            int sum = 0;
            foreach (var item in asList)
            {
                sum += item.TotalCost;
            }
            lblTotalCost.Text = sum.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < asList.Count; i++)
            {
                if (asList[i].Mat_No == int.Parse(dgvOrder.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    asList.RemoveAt(i);
                }
            }
            DGVBuilder();
            int sum = 0;
            foreach (var item in asList)
            {
                sum += item.TotalCost;
            }
            lblTotalCost.Text = sum.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(asList.Count == 0))
                {
                    foreach (OrderInfo item in asList)
                    {
                        mdao.ProcessAS(asNo, item.Mat_No, item.Mat_EA, item.TotalCost);
                    }
                    MessageBox.Show("교체 성공");
                    Close();
                }
                else
                {
                    MessageBox.Show("품목을 등록하십시오");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("교체 실패 \n" + ex.Message);
            }
        }
    }
}