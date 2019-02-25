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
    public partial class FrmProducts : Form
    {
        ProductsDAO pdao = new ProductsDAO();
        byte[] imageArr;
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            pdao.InsertProducts(tbMatType.Text, int.Parse(tbPrice.Text), tbName.Text, tbSpec.Text, imageArr);
        }

        private void btnImgSearch_Click(object sender, EventArgs e)
        {
            string openstrFilename;

            ofdProImg.Title = "이미지 읽기";
            ofdProImg.Filter = "Bitmap File(*.bmp)|*.bmp|JPEG File(*.jpg)|*.jpg|Png(*.png)|*.png";

            if (ofdProImg.ShowDialog() == DialogResult.OK)
            {
                openstrFilename = ofdProImg.FileName;
                Image image = Image.FromFile(openstrFilename);
                pbProImg.Image = image;
                FileStream fs = new FileStream(ofdProImg.FileNames[0], FileMode.OpenOrCreate, FileAccess.Read);

                System.Data.SqlClient.SqlParameter[] sqlParameter = new System.Data.SqlClient.SqlParameter[1];
                imageArr = new byte[fs.Length];
                fs.Read(imageArr, 0, Convert.ToInt32(fs.Length));
                fs.Close();
            }
        }
    }
}