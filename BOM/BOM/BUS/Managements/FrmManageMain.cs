using BOM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Managements
{
    public partial class FrmManageMain : Form
    {
        MatDAO md = new MatDAO();
        public FrmManageMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int no = int.Parse(textBox1.Text);
            //string name = textBox2.Text;
            //md.InsertMat(no, name);

            md.DeleteMat(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }
    }
}
