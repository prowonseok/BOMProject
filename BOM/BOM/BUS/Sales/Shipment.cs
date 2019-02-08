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
using System.Windows.Forms.VisualStyles;

namespace BOM.BUS.Sales
{
    public partial class Shipment : Form
    {
        DBProcessor dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public Label Lbltest { get { return lblAddr; } set { lblAddr = value; } }
        List<ShipmentVO> ProList;
        public Shipment()
        {

        }
        int orderNo = 0;
        public Shipment(int orderNo) //주문번호를 넘겨받음
        {
            InitializeComponent();
            this.orderNo = orderNo;
            ProList = new List<ShipmentVO>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddreesForm ad = new AddreesForm();
            ad.Owner = this;
            ad.Show();
        }

        private void Shipment_Load(object sender, EventArgs e)
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
                    ProPrice = Int32.Parse(item["Cus_Order_Price"].ToString()),
                    ResidualAmount = Int32.Parse(item["RemainingAmount"].ToString())
                });                
            }
            lblShipDate.Text = DateTime.Now.AddDays(2).ToShortDateString();
            dgvProList.DataSource = ProList;
            dgvProList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvProList.Columns[0].HeaderText = "제품명";
            dgvProList.Columns[1].HeaderText = "개수";
            dgvProList.Columns[2].HeaderText = "가격";
            dgvProList.Columns[3].HeaderText = "잔여량";            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            DataGridViewDisableButtonColumn column1 =
                new DataGridViewDisableButtonColumn();
            
            column1.Name = "발주";
            
            dgvProList.Columns.Add(column1);

            // Set the text for each button.
            for (int i = 0; i < dgvProList.RowCount; i++)
            {
                dgvProList.Rows[i].Cells["발주"].Value =
                    "발주신청";
            }
            
            dgvProList.CurrentCellDirtyStateChanged += DgvProList_CurrentCellDirtyStateChanged;
            dgvProList.CellClick += DgvProList_CellClick;
            

            this.Controls.Add(dgvProList);
            for (int i = 0; i < dgvProList.Rows.Count; i++)
            {
                
                if (Int32.Parse(dgvProList.Rows[i].Cells["ProEa"].Value.ToString()) < Int32.Parse(dgvProList.Rows[i].Cells["residualAmount"].Value.ToString()))
                {
                    DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dgvProList.Rows[i].Cells["발주"];

                    //DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgvProList.Rows[e.RowIndex].Cells["CheckBoxes"];
                    buttonCell.Enabled = false;

                    dgvProList.Invalidate();
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void DgvProList_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void DgvProList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProList.IsCurrentCellDirty)
            {
                dgvProList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            SalesInquiry sI = new SalesInquiry();
            sI.Show();
            this.Close();
        }

    }
    public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
    {
        public DataGridViewDisableButtonColumn()
        {
            this.CellTemplate = new DataGridViewDisableButtonCell();
        }
    }

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

        // Override the Clone method so that the Enabled property is copied.
        public override object Clone()
        {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        // By default, enable the button cell.
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
            // The button cell is disabled, so paint the border,  
            // background, and disabled button for the cell.
            if (!this.enabledValue)
            {
                // Draw the cell background, if specified.
                if ((paintParts & DataGridViewPaintParts.Background) ==
                    DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                // Draw the cell borders, if specified.
                if ((paintParts & DataGridViewPaintParts.Border) ==
                    DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                // Calculate the area in which to draw the button.
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment =
                    this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                // Draw the disabled button.                
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    PushButtonState.Disabled);

                // Draw the disabled button text. 
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
                // The button cell is enabled, so let the base class 
                // handle the painting.
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
        }
    }
}
