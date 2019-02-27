using BOM.DAO;
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
    public partial class FrmMatAdd : Form
    {
        MatDAO md;
        private object[] listArray;

        public FrmMatAdd()
        {
            InitializeComponent();
        }

        public FrmMatAdd(object md, object[] listArray) : this()
        {
            this.md = (MatDAO)md;
            this.listArray = listArray;
        }

        private void FrmMatAdd_Load(object sender, EventArgs e)
        {
            foreach (VO.Materials_TypeVO item in (List<VO.Materials_TypeVO>)listArray[0])
            {
                cbMatType.Items.Add(item.Mat_Type_Category);
            }
            foreach (VO.OffererVO item in (List<VO.OffererVO>)listArray[1])
            {
                cbOfferer.Items.Add(item.OffName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMatNo.Text) && !string.IsNullOrEmpty(cbMatLvl.Text) && !string.IsNullOrEmpty(cbMatType.Text) && !string.IsNullOrEmpty(tbName.Text))
            {
                md.InsertMat(int.Parse(tbMatNo.Text), int.Parse(((List<VO.Materials_TypeVO>)listArray[0])[cbMatType.SelectedIndex].Mat_Type_No.ToString()), tbManufac.Text, tbName.Text, int.Parse(tbCost.Text.Replace(",", "")), cbMatLvl.SelectedIndex, int.Parse(tbMatEa.Text), int.Parse(((List<VO.OffererVO>)listArray[1])[cbOfferer.SelectedIndex].OffNo.ToString()));
                MessageBox.Show("성공적으로 등록하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
            else
            {
                MessageBox.Show("자재 번호, 자재 분류, 자재명 그리고 자재 단계는 필수 입력 사항입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbMatNo_TextChanged(object sender, EventArgs e)
        {
            if (!(cbMatType.SelectedIndex == -1))
            {

            }
            else if (cbMatType.SelectedIndex == -1)
            {

            }
        }

        private void tbCost_TextChanged(object sender, EventArgs e)
        {
            string[] sp = tbCost.Text.Split(',');
            if (sp[sp.Length - 1].Length >= 4)
            {
                tbCost.Text = tbCost.Text.Insert(tbCost.Text.Length - 1, ",");
                tbCost.Select(tbCost.Text.Length, 0);
            }
            string tb = tbCost.Text.Replace(",", "");
            try
            {
                if (string.IsNullOrEmpty(tb))
                {
                    return;
                }
                else
                {
                    uint.Parse(tb);
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("입력 범위를 초과하였습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbMatEa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                string[] sp = tbCost.Text.Split(',');
                if (sp[sp.Length - 1].Length >= 4)
                {
                    tbCost.Text = tbCost.Text.Insert(tbCost.Text.Length - 1, ",");
                    tbCost.Select(tbCost.Text.Length, 0);
                }
            }
        }

        private void tbMatNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void cbMatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMatNo.Text = ((List<VO.Materials_TypeVO>)listArray[0])[cbMatType.SelectedIndex].Mat_Type_No;
        }
    }
}