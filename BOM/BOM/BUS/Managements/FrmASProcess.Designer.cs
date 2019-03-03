namespace BOM.BUS.Managements
{
    partial class FrmASProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrderList = new System.Windows.Forms.Label();
            this.lblEA = new System.Windows.Forms.Label();
            this.lblMatTotal = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblOfferer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudEA = new System.Windows.Forms.NumericUpDown();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbOfferer = new System.Windows.Forms.TextBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderList.Location = new System.Drawing.Point(16, 27);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(71, 15);
            this.lblOrderList.TabIndex = 35;
            this.lblOrderList.Text = "발주서 현황";
            // 
            // lblEA
            // 
            this.lblEA.AutoSize = true;
            this.lblEA.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEA.Location = new System.Drawing.Point(601, 279);
            this.lblEA.Name = "lblEA";
            this.lblEA.Size = new System.Drawing.Size(31, 15);
            this.lblEA.TabIndex = 34;
            this.lblEA.Text = "수량";
            // 
            // lblMatTotal
            // 
            this.lblMatTotal.AutoSize = true;
            this.lblMatTotal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatTotal.Location = new System.Drawing.Point(601, 219);
            this.lblMatTotal.Name = "lblMatTotal";
            this.lblMatTotal.Size = new System.Drawing.Size(31, 15);
            this.lblMatTotal.TabIndex = 33;
            this.lblMatTotal.Text = "합계";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCost.Location = new System.Drawing.Point(601, 159);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 15);
            this.lblCost.TabIndex = 32;
            this.lblCost.Text = "단가";
            // 
            // lblOfferer
            // 
            this.lblOfferer.AutoSize = true;
            this.lblOfferer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOfferer.Location = new System.Drawing.Point(601, 97);
            this.lblOfferer.Name = "lblOfferer";
            this.lblOfferer.Size = new System.Drawing.Size(43, 15);
            this.lblOfferer.TabIndex = 31;
            this.lblOfferer.Text = "공급사";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(601, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "자재명";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(551, 454);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.Location = new System.Drawing.Point(648, 454);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 29);
            this.btnOrder.TabIndex = 28;
            this.btnOrder.Text = "교체";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemove.Location = new System.Drawing.Point(515, 268);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 29);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = ">>";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTotalCost.Location = new System.Drawing.Point(603, 238);
            this.tbTotalCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.Size = new System.Drawing.Size(120, 23);
            this.tbTotalCost.TabIndex = 26;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalCost.Location = new System.Drawing.Point(601, 435);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 15);
            this.lblTotalCost.TabIndex = 25;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.Location = new System.Drawing.Point(601, 359);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "총 금액";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(515, 210);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "<<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudEA
            // 
            this.nudEA.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudEA.Location = new System.Drawing.Point(603, 298);
            this.nudEA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudEA.Name = "nudEA";
            this.nudEA.Size = new System.Drawing.Size(120, 23);
            this.nudEA.TabIndex = 22;
            this.nudEA.ValueChanged += new System.EventHandler(this.nudEA_ValueChanged);
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCost.Location = new System.Drawing.Point(603, 178);
            this.tbCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCost.Name = "tbCost";
            this.tbCost.ReadOnly = true;
            this.tbCost.Size = new System.Drawing.Size(120, 23);
            this.tbCost.TabIndex = 21;
            // 
            // tbOfferer
            // 
            this.tbOfferer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbOfferer.Location = new System.Drawing.Point(603, 118);
            this.tbOfferer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOfferer.Name = "tbOfferer";
            this.tbOfferer.ReadOnly = true;
            this.tbOfferer.Size = new System.Drawing.Size(120, 23);
            this.tbOfferer.TabIndex = 20;
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(603, 58);
            this.cbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 23);
            this.cbName.TabIndex = 19;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(16, 58);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(493, 425);
            this.dgvOrder.TabIndex = 18;
            // 
            // FrmASProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 510);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.lblEA);
            this.Controls.Add(this.lblMatTotal);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblOfferer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudEA);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbOfferer);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.dgvOrder);
            this.Name = "FrmASProcess";
            this.Text = "AS 처리";
            this.Load += new System.EventHandler(this.FrmASProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Label lblEA;
        private System.Windows.Forms.Label lblMatTotal;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblOfferer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudEA;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbOfferer;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.DataGridView dgvOrder;
    }
}