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
        MatDAO mdao = new MatDAO();
        DataTable dt;

        byte[] imageArr;
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                pdao.InsertProducts(int.Parse(dt.Rows[cbMatType.SelectedIndex]["Mat_Type_No"].ToString()), tbName.Text, int.Parse(tbPrice.Text), int.Parse(tbPrice.Text), tbName.Text, tbSpec.Text, imageArr);
                MessageBox.Show("등록 성공");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("등록 실패");
            }
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            using (DataTable dt = mdao.SelectMat())
            { 
                foreach (DataRow item in dt.Rows)
                {
                    switch (int.Parse(item["Mat_Type_No"].ToString()))
                    {
                        case 1000:
                            cbCPU.Items.Add(item["Mat_Name"].ToString());
                            break;
                        case 2000:
                            cbMB.Items.Add(item["Mat_Name"].ToString());
                            break;
                        case 3000:
                            cbVGA.Items.Add(item["Mat_Name"].ToString());
                            break;
                        case 4000:
                            cbRAM.Items.Add(item["Mat_Name"].ToString());
                            break;
                        case 5000:
                            cbHDD.Items.Add(item["Mat_Name"].ToString());
                            break;
                        case 6000:
                            cbSSD.Items.Add(item["Mat_Name"].ToString());
                            break;
                        case 7000:
                            cbPSU.Items.Add(item["Mat_Name"].ToString());
                            break;
                        case 8000:
                            cbCASE.Items.Add(item["Mat_Name"].ToString());
                            break;
                        case 9000:
                            cbCOOLER.Items.Add(item["Mat_Name"].ToString());
                            break;
                    }
                }
            }
            cbCPU.Text = string.Empty;
            cbMB.Text = string.Empty;
            cbVGA.Text = string.Empty;
            cbHDD.Text = string.Empty;
            cbSSD.Text = string.Empty;
            cbRAM.Text = string.Empty;
            cbPSU.Text = string.Empty;
            cbCASE.Text = string.Empty;
            cbCOOLER.Text = string.Empty;

            cbCPU.SelectedIndexChanged += ComboBoxHandler;
            cbMB.SelectedIndexChanged += ComboBoxHandler;
            cbVGA.SelectedIndexChanged += ComboBoxHandler;
            cbHDD.SelectedIndexChanged += ComboBoxHandler;
            cbSSD.SelectedIndexChanged += ComboBoxHandler;
            cbRAM.SelectedIndexChanged += ComboBoxHandler;
            cbPSU.SelectedIndexChanged += ComboBoxHandler;
            cbCASE.SelectedIndexChanged += ComboBoxHandler;
            cbCOOLER.SelectedIndexChanged += ComboBoxHandler;

            dt = pdao.ProSelectFromMat();
            foreach (DataRow item in dt.Rows)
            {
                cbMatType.Items.Add(item["Mat_Type_Category"].ToString());
            }
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
        
        private void ComboBoxHandler(object sender, EventArgs e)
        {
            tbSpec.Text = string.Empty;
            string[] tbStrings = { cbCPU.Text, cbMB.Text, cbVGA.Text, cbRAM.Text, cbHDD.Text, cbSSD.Text, cbPSU.Text, cbCASE.Text, cbCOOLER.Text };

            foreach (string item in tbStrings)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    tbSpec.Text += item + "\r\n";
                }
                else if (string.IsNullOrEmpty(item))
                {
                    
                }
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}