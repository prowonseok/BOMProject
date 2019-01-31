using System;
using System.Windows.Forms;
using CustomerApp.DAO;

namespace CustomerApp.BUS
{
    public partial class FrmAddr : Form
    {
        private string searchType = string.Empty;
        private string searchTxt = string.Empty;
        private string choiceAddr;

        public string ChoiceAddr
        {
            get { return choiceAddr; }
            set { choiceAddr = value; }
        }

        public FrmAddr()
        {
            InitializeComponent();
        }

        private void FrmAddr_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Text = "주소 찾기";
            rdoDong.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchType = getSearchType();
            searchTxt = txtSearch.Text.Trim();
            SearchAddr searchAddr = new SearchAddr();

            gViewResult.DataSource = searchAddr.Search(searchType, searchTxt);

            gViewResult.Columns[0].HeaderText = "도로명 주소";
            gViewResult.Columns[1].HeaderText = "우편번호";

            gViewResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gViewResult.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //MessageBox.Show("에러 코드 : " + searchAddr.StatusCode, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string getSearchType()
        {
            if (rdoDong.Checked) searchType = "dong";
            else if (rdoRoad.Checked) searchType = "road";
            else if (rdoPost.Checked) searchType = "post";

            return searchType;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            choiceAddr = gViewResult.SelectedRows[0].Cells[0].Value.ToString();
            Close();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void rdoDong_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void rdoRoad_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void rdoPost_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }
    }
}
