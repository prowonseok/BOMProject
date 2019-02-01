using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM
{
    public partial class FrmBomSearchPro : Form
    {
        DAO.BomDAO bDao;
        public FrmBomSearchPro()
        {
            InitializeComponent();
        }

        private void FrmBomSearchPro_Load(object sender, EventArgs e)
        {
            bDao = new DAO.BomDAO();
            dgvProInfo.DataSource = bDao.SelectPro();
        }
    }
}
