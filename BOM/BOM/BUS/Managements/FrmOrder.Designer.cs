namespace BOM.BUS.Managements
{
    partial class FrmOrder
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.tbOfferer = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.nudEA = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOfferer = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblMatTotal = new System.Windows.Forms.Label();
            this.lblEA = new System.Windows.Forms.Label();
            this.lblOrderList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 44);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(493, 377);
            this.dgvOrder.TabIndex = 0;
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(783, 44);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 20);
            this.cbName.TabIndex = 1;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // tbOfferer
            // 
            this.tbOfferer.Location = new System.Drawing.Point(783, 99);
            this.tbOfferer.Name = "tbOfferer";
            this.tbOfferer.ReadOnly = true;
            this.tbOfferer.Size = new System.Drawing.Size(120, 21);
            this.tbOfferer.TabIndex = 2;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(783, 155);
            this.tbCost.Name = "tbCost";
            this.tbCost.ReadOnly = true;
            this.tbCost.Size = new System.Drawing.Size(120, 21);
            this.tbCost.TabIndex = 3;
            // 
            // nudEA
            // 
            this.nudEA.Location = new System.Drawing.Point(783, 267);
            this.nudEA.Name = "nudEA";
            this.nudEA.Size = new System.Drawing.Size(120, 21);
            this.nudEA.TabIndex = 4;
            this.nudEA.ValueChanged += new System.EventHandler(this.nudEA_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(539, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "<<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(675, 327);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 12);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "총 금액";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(781, 327);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 12);
            this.lblTotalCost.TabIndex = 7;
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Location = new System.Drawing.Point(783, 211);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.Size = new System.Drawing.Size(120, 21);
            this.tbTotalCost.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(539, 233);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = ">>";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(828, 385);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "구매";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(731, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(679, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "자재명";
            // 
            // lblOfferer
            // 
            this.lblOfferer.AutoSize = true;
            this.lblOfferer.Location = new System.Drawing.Point(679, 102);
            this.lblOfferer.Name = "lblOfferer";
            this.lblOfferer.Size = new System.Drawing.Size(41, 12);
            this.lblOfferer.TabIndex = 13;
            this.lblOfferer.Text = "공급사";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(691, 158);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(29, 12);
            this.lblCost.TabIndex = 14;
            this.lblCost.Text = "단가";
            // 
            // lblMatTotal
            // 
            this.lblMatTotal.AutoSize = true;
            this.lblMatTotal.Location = new System.Drawing.Point(691, 214);
            this.lblMatTotal.Name = "lblMatTotal";
            this.lblMatTotal.Size = new System.Drawing.Size(29, 12);
            this.lblMatTotal.TabIndex = 15;
            this.lblMatTotal.Text = "합계";
            // 
            // lblEA
            // 
            this.lblEA.AutoSize = true;
            this.lblEA.Location = new System.Drawing.Point(691, 269);
            this.lblEA.Name = "lblEA";
            this.lblEA.Size = new System.Drawing.Size(29, 12);
            this.lblEA.TabIndex = 16;
            this.lblEA.Text = "수량";
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Location = new System.Drawing.Point(12, 19);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(69, 12);
            this.lblOrderList.TabIndex = 17;
            this.lblOrderList.Text = "발주서 현황";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
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
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.TextBox tbOfferer;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.NumericUpDown nudEA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOfferer;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblMatTotal;
        private System.Windows.Forms.Label lblEA;
        private System.Windows.Forms.Label lblOrderList;
    }
}