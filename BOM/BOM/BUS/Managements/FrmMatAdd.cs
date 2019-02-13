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
            foreach (string item in listArray[0])
            {
                cbMatType.Items.Add(item);
            }
            foreach (string item in listArray[1])
            {
                cbOfferer.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMatNo.Text) && !string.IsNullOrEmpty(tbMatLvl.Text) && !string.IsNullOrEmpty(cbMatType.Text) && !string.IsNullOrEmpty(tbName.Text))
            {
                //md.InsertMat(tbMatNo.Text, cbMatType., );
            }
            else
            {
                MessageBox.Show("자재 번호, 자재 분류, 자재명 그리고 자재 단계는 필수 입력 사항입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbMatNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbMatNo.Text == string.Empty)
                {
                    return;
                }
                int.Parse(tbMatNo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("자재 번호는 정수만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMatNo.Clear();
                return;
            }
        }

        private void tbCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 188)
            {
                MessageBox.Show("단가는 정수만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCost.Clear();
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
            catch (Exception)
            {
                MessageBox.Show("단가는 정수만 입력 가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCost.Clear();
            }
        }
    }
}
