using BOM.DAO;
using BOM.VO;
using dllPackager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Sales
{
    public partial class TraderSet : Form
    {        
        TraderSetDao tsd;           
        public TextBox TextBoxText
        {
            get { return txtOffAddr; }
            set { txtOffAddr = value; }
        }

        public TraderSet()
        {
            InitializeComponent();            
            tsd = new TraderSetDao();
        }
        DataTable offLst;
        DataTable proTypeLst;
        DataTable proList;

        private void TraderSet_Load(object sender, EventArgs e)
        {
            offLst = new DataTable();
            offLst = tsd.OffList();

            foreach (DataRow item in offLst.Rows)
            {
                comboOffList.Items.Add(item["Off_Name"].ToString());
                comboOff.Items.Add(item["Off_Name"].ToString());
            }

            proTypeLst = new DataTable();
            proTypeLst = tsd.proTypeList();
            foreach (DataRow item in proTypeLst.Rows)
            {
                comboProTypeList.Items.Add(item["Mat_Type_Category"]);
                if (item["Mat_Type_Category"].ToString() != "")
                {
                    comboProTypeList2.Items.Add(item["Mat_Type_Category"]);
                }                
            }

            proList = new SalesDao().MatList2();
            foreach (DataRow item in proList.Rows)
            {
                comboMatList.Items.Add(item["Mat_Name"].ToString());
            }

        }        
        /// <summary>
        /// 필수입력값 체크후 거래처를 등록하는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtOffName.Text != "" && txtOwnerName.Text != "" && txtOffAddr.Text != "" && txtManager.Text != "" && txtManagerMobile.Text != "")
            {
                label18.Visible = label19.Visible = label20.Visible = label21.Visible = label22.Visible = false;
                MessageBox.Show(tsd.OffInsert(txtOffName.Text, txtOwnerName.Text, txtOffAddr.Text, txtManager.Text, txtManagerMobile.Text, txtOffMobile.Text));
            }
            else
            {
                label18.Visible = label19.Visible = label20.Visible = label21.Visible = label22.Visible = true;
            }
        }
        int offNo;
        int typeNo; 
        int OffIndexNo; // 거래처 번호 변수
        /// <summary>
        /// 거래처 선택시 DB에 저장된 거래처 번호를 불러오는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void comboOffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OffIndexNo = Int32.Parse(comboOffList.SelectedIndex.ToString());           
        }
        int typeindexNo; // 제품 타입 번호 변수
        /// <summary>
        /// 제품타입 선택시 DB에 저장된 제품타입 번호를 불러오는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboProTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeindexNo = Int32.Parse(comboProTypeList.SelectedIndex.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddreesForm ad = new AddreesForm(2);
            ad.Owner = this;
            ad.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {           
            if (e.TabPageIndex == 0)
            {
                this.Size = new Size(513, 462);
            }
            else if(e.TabPageIndex == 1)
            {
                this.Size = new Size(343, 464);
            }
            else
            {
                this.Size = new Size(513, 462);
            }
        }
        string matlevel = "";
        /// <summary>
        /// 변경할 데이터를 DB에 저장하는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboMatList.SelectedItem!=null)
            {
                if (MessageBox.Show("저장?", "!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (comboMatLevel2.SelectedItem == null)
                    {
                        matlevel = "";
                    }
                    else
                    {
                        matlevel = comboMatLevel2.SelectedItem.ToString();
                    }
                    tsd.MatModify(comboMatList.SelectedItem.ToString(), modifyOffNo, modifyMatTypeNo, txtManufactur2.Text, txtMatName2.Text, txtMatPrice2.Text, matlevel);

                    MessageBox.Show("변경완료");
                    TraderSet_Load(null, null);
                    comboMatList_DropDownClosed(null, null);
                }               
            }
            else
            {
                MessageBox.Show("변경할 제품을 클릭하세요");
            }
        }

        
        /// <summary>
        /// 제품을 삭제하는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboMatList.SelectedItem !=null)
            {
                if (true)
                {
                    MessageBox.Show(tsd.MatDelete(comboMatList.SelectedItem.ToString()).ToString());
                }
            }
            else
            {
                MessageBox.Show("삭제할 제품 선택하세요");
            }
            
        }
        /// <summary>
        /// 변경할 제품 선택시 제품의 스펙을 보여주는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboMatList_DropDownClosed(object sender, EventArgs e)
        {
            if (comboMatList.SelectedIndex != -1)
            {
                lbl1.Text = lbl2.Text = lbl3.Text = lbl4.Text = lbl5.Text = lbl6.Text = "";
                foreach (var item in tsd.LinqMatView(comboMatList.Items[comboMatList.SelectedIndex].ToString()))
                {
                    if (item.Off_Name != null)
                    {
                        lbl1.Text = item.Off_Name;
                    }
                    lbl2.Text = item.Mat_Type_Category;
                    if (item.Mat_Manufactur != null)
                    {
                        lbl3.Text = item.Mat_Manufactur;
                    }
                    lbl4.Text = item.Mat_Name;
                    if (item.Mat_Name.ToString() != null)
                    {
                        lbl5.Text = item.Mat_Cost.ToString();
                    }
                    lbl6.Text = item.Mat_Level.ToString();
                } 
            }

        }
        string modifyOffNo = ""; // 변경할 거래처 번호 변수
        /// <summary>
        /// DB에 저장된 변경할 거래처 번호를 받아오는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboOff_DropDownClosed(object sender, EventArgs e)
        {
            if (comboOff.SelectedIndex != -1)
            {
                modifyOffNo = new TraderSetDao().GetOffNo(comboOff.SelectedItem.ToString());
            }
           
            
        }
        string modifyMatTypeNo = ""; // 제품타입 변수
        /// <summary>
        /// DB에 저저장된 변경할 제품타입 번호를 받아오는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboProTypeList2_DropDownClosed(object sender, EventArgs e)
        {
            if (comboProTypeList2.SelectedIndex != -1)
            {               
                modifyMatTypeNo = new TraderSetDao().GetMatTypeNo(comboProTypeList2.SelectedItem.ToString());
            }
        }       

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (comboOffList.Text != "" && comboProTypeList.Text != "" && txtMatName.Text != "" && comboMatLevel.Text != "")
            {
                offNo = Int32.Parse(offLst.Rows[OffIndexNo]["Off_No"].ToString());
                typeNo = Int32.Parse(proTypeLst.Rows[typeindexNo]["Mat_Type_No"].ToString());

                MessageBox.Show(tsd.MatInsert(typeNo, txtManufactur.Text, txtMatName.Text, Int32.Parse(txtMatPrice.Text), comboMatLevel.Text, Int32.Parse(txtMatEa.Text), offNo));
            }
            else
            {
                MessageBox.Show("거래처, 제품타입, 제품이름, 제품라벨은 필수항목 입니다.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOffMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtManagerMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
