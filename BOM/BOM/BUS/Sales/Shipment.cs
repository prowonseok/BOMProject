using BOM.DAO;
using BOM.VO;
using dllPackager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BOM.BUS.Sales
{
    public partial class Shipment : Form
    {
        DBProcessor dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public Label Lbltest { get { return lblAddr; } set { lblAddr = value; } }
        string fIlePath = null; //파일 지정경로 변수
        
        string fIlePath2 = Application.StartupPath + @"\Excel\Shipment.xlsx";
        List<ShipmentVO> ProList;
        
        public Shipment()
        {
            InitializeComponent();
        }
        int orderNo = 0;
        /// <summary>
        /// 주문번호를 넘겨받는 오버로딩된 생성자
        /// </summary>
        /// <param name="orderNo">매개변수 주문번호</param>
        public Shipment(int orderNo) 
        {
            InitializeComponent();
            this.orderNo = orderNo;
            ProList = new List<ShipmentVO>();            
        }
        /// <summary>
        /// 주소변경시 주소변경 폼을 띄워주는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) 
        {            
            AddreesForm ad = new AddreesForm(1);
            ad.Owner = this;
            ad.Show();
        }
        /// <summary>
        /// 넘겨받은 준문정보로 출하지시서 폼의 내용을 표시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shipment_Load(object sender, EventArgs e) 
        {
            dgvProList.Font = new Font("맑은고딕", 9);

            if (this.orderNo != 0 )
            {
                string sp = "Bom_JW_Shipment_Procedure";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@OrderNo", orderNo);
                DataTable dt = dbp.ExecuteParametersDT(sp, sqlParameters);


                foreach (DataRow item in dt.Rows)
                {
                    lblOrderNo.Text = item["Cus_Order_OrderNO"].ToString();
                    lblDate.Text = DateTime.Parse(item["Cus_Order_Date"].ToString()).ToShortDateString().ToString();
                    lblCus.Text = item["Cus_ID"].ToString();
                    lblEmp.Text = item["Emp_Name"].ToString();
                    lblPhone.Text = item["Cus_Phone"].ToString();
                    lblAddr.Text = item["Cus_Addr"].ToString();

                    ProList.Add(new ShipmentVO
                    {
                        ProName = item["Pro_Name"].ToString(),
                        ProEa = Int32.Parse(item["Cus_Order_EA"].ToString()),
                        ProPrice = String.Format("{0:##,##0}", item["Cus_Order_Price"]) + " 원",
                        ResidualAmount = Int32.Parse(item["RemainingAmount"].ToString())

                    });
                }
                lblShipDate.Text = DateTime.Now.AddDays(2).ToShortDateString();
                dgvProList.DataSource = ProList;
                dgvProList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvProList.Columns[0].Width = 200;
                dgvProList.Columns[1].Width = 40;
                dgvProList.Columns[2].Width = 90;
                dgvProList.Columns[3].Width = 90;
                dgvProList.Columns[0].HeaderText = "제품명";
                dgvProList.Columns[1].HeaderText = "개수";
                dgvProList.Columns[2].HeaderText = "가격";
                dgvProList.Columns[3].HeaderText = "잔여량";         

                DataGridViewDisableButtonColumn column1 =
                    new DataGridViewDisableButtonColumn();

                column1.Name = "발주";
                dgvProList.Columns.Add(column1);
              
                for (int i = 0; i < dgvProList.RowCount; i++)
                {
                    dgvProList.Rows[i].Cells["발주"].Value =
                        "발주신청";
                }
                               
                dgvProList.CellClick += DgvProList_CellClick;

                this.Controls.Add(dgvProList);
                for (int i = 0; i < dgvProList.Rows.Count; i++)
                {

                    if (Int32.Parse(dgvProList.Rows[i].Cells["ProEa"].Value.ToString()) < Int32.Parse(dgvProList.Rows[i].Cells["residualAmount"].Value.ToString()))
                    {
                        DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dgvProList.Rows[i].Cells["발주"];
                        buttonCell.Enabled = false;
                        dgvProList.Invalidate();
                    }
                } 
            }
            if (lblOrderNo.Text !="")
            {
                btnPath.Enabled = btnConfirm.Enabled = true;
            }
        }
        /// <summary>
        /// 제품 보유량이 부족시 발주버튼이 활성화되고 발주가 가능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvProList_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (dgvProList.Columns[e.ColumnIndex].Name == "발주")
                {
                    DataGridViewDisableButtonCell buttonCell =
                        (DataGridViewDisableButtonCell)dgvProList.
                        Rows[e.RowIndex].Cells["발주"];

                    if (buttonCell.Enabled)
                    {
                        MessageBox.Show("물품 구매신청 폼으로 데이터주고 구매폼 띄움");
                    }
                }
            }
        }
        /// <summary>
        /// 셀내용 변경시(셀체크 변경시) 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvProList_CurrentCellDirtyStateChanged(object sender, EventArgs e) 
        {
            
            if (dgvProList.IsCurrentCellDirty)
            {
                dgvProList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }        

        private void button2_Click(object sender, EventArgs e) //판매조회폼을 띄워줌
        {
            SalesInquiry sI = new SalesInquiry();
            sI.Show();
            this.Close();
        }
        /// <summary>
        /// 클릭시 출하지시서 내용을 엑셀로 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e) 
        {            
            if (txtconf.Text =="")
            {
                MessageBox.Show("확인란에 서명하세요");
            }
            else
            {
                List<string> OrderInfoList = new List<string>();
                OrderInfoList.Add(lblOrderNo.Text);
                OrderInfoList.Add(lblShipDate.Text);
                OrderInfoList.Add(lblCus.Text);
                OrderInfoList.Add(lblEmp.Text);
                OrderInfoList.Add(lblPhone.Text);
                if (lblAddr.Text.IndexOf("구주소") ==-1)
                {
                    OrderInfoList.Add(lblAddr.Text);                    
                }
                else
                {
                    OrderInfoList.Add(lblAddr.Text.Substring(0, lblAddr.Text.IndexOf("구주소")));
                }               
                
                string excelStr = new SalesExcelDao().WriteExcelData(OrderInfoList , ProList, fIlePath, fIlePath2);
                MessageBox.Show(excelStr);                
            }
        }        
        /// <summary>
        /// 엑셀저장 경로 지정하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".xlsx";      
            saveFileDialog1.Filter = "Excel|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fIlePath = saveFileDialog1.FileName;                
            }
        }
    }
    public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
    {
        public DataGridViewDisableButtonColumn()
        {
            this.CellTemplate = new DataGridViewDisableButtonCell();
        }
    }  
    /// <summary>
    /// 그리드뷰에 버튼을 만드는 메서드
    /// </summary>
    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabledValue;
        public bool Enabled
        {
            get
            {
                return enabledValue;
            }
            set
            {
                enabledValue = value;
            }
        }
        
        public override object Clone()
        {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        /// <summary>
        /// 버튼셀 활성화
        /// </summary>
        public DataGridViewDisableButtonCell()
        {
            this.enabledValue = true;
        }

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates elementState, object value,
            object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // 버튼 비활성시 셀테두리,배경을 비활성 버튼으로 표시
            if (!this.enabledValue)
            {
                //버튼 활성화시 배경을 그린다.
                if ((paintParts & DataGridViewPaintParts.Background) ==
                    DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                //버튼 활성시 버튼 테두리를그린다
                if ((paintParts & DataGridViewPaintParts.Border) ==
                    DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                //버튼 그릴 영역 선택
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment =
                    this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                //비활성화된 버튼을 나타낸다.               
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    PushButtonState.Disabled);

                //비활성화된 버튼 텍스트를 그린다 
                if (this.FormattedValue is String)
                {
                    TextRenderer.DrawText(graphics,
                        (string)this.FormattedValue,
                        this.DataGridView.Font,
                        buttonArea, SystemColors.GrayText);
                }
            }
            else
            {
                
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
        }
    } //그리드뷰 버튼 영역, 모양 설정
}
