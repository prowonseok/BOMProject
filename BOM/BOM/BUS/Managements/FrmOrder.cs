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
    public partial class FrmOrder : Form
    {
        int orderNo;
        int matNo;
        int offNo;
        OfferOrderDAO ood = new OfferOrderDAO();
        List<OffererOrderViewVO> oovList = new List<OffererOrderViewVO>();
        List<OrderInfo> orderList = new List<OrderInfo>();

        public FrmOrder(int orderNo)
        {
            InitializeComponent();
            this.orderNo = orderNo;
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            FormBuilder();
        }

        private void FormBuilder()
        {
            dgvOrder.DataSource = orderList;
            dgvOrder.Columns[0].Name = "품명";
            dgvOrder.Columns[1].Name = "판매자";
            dgvOrder.Columns[2].Name = "단가";
            dgvOrder.Columns[3].Name = "개수";
            dgvOrder.Columns[4].Name = "합계";
            DataTable dt = ood.SelectOrder();
            foreach (DataRow item in dt.Rows)
            {
                oovList.Add(new OffererOrderViewVO(int.Parse(item["Mat_No"].ToString()), int.Parse(item["Off_No"].ToString()), item["Mat_Name"].ToString(), item["Off_Name"].ToString(), int.Parse(item["Mat_Cost"].ToString())));
            }
            foreach (OffererOrderViewVO item in oovList)
            {
                cbName.Items.Add(item.Mat_Name);
            }
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
            tbTotalCost.Text = (int.Parse(tbCost.Text) * nudEA.Value).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudEA.Value != 0)
            {
                orderList.Add(new OrderInfo(matNo, cbName.Text, oovList[cbName.SelectedIndex].Off_No, tbOfferer.Text, int.Parse(tbCost.Text), int.Parse(nudEA.Value.ToString()), int.Parse(tbTotalCost.Text)));
            }
            //Controls.Clear();
            //InitializeComponent();
            //FormBuilder();
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = orderList;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].Mat_No == int.Parse(dgvOrder.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    orderList.RemoveAt(i);
                }
            }
            Controls.Clear();
            InitializeComponent();
            FormBuilder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            foreach (OrderInfo item in orderList)
            {
                ood.InsertOrder(orderNo + 1, item.Mat_No, item.Mat_EA, item.Off_No);
            }
        }
    }
}