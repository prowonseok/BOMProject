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
    public partial class DataInsertForm : Form
    {
        public DataInsertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateInsert d = new DateInsert();
            MessageBox.Show(d.DateInsert1());
        }
    }
}
