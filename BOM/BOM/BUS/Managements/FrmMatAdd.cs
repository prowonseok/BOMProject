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
        private List<string>[] listArray;

        public FrmMatAdd()
        {
            InitializeComponent();
        }

        public FrmMatAdd(List<string>[] listArray) : this()
        {
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

        }

        private void cbManufac_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                MessageBox.Show("자재 번호에는 정수만 입력 가능합니다.");
                tbMatNo.Clear();
                return;
            }
        }
    }
}
