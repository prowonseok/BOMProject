namespace BOM.BUS.Managements.Controls
{
    partial class CtrlMatAdd
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMatLvl = new System.Windows.Forms.ComboBox();
            this.tbManufac = new System.Windows.Forms.TextBox();
            this.cbOfferer = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbMatType = new System.Windows.Forms.ComboBox();
            this.lblOfferer = new System.Windows.Forms.Label();
            this.lblMatEa = new System.Windows.Forms.Label();
            this.tbMatEa = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMatNo = new System.Windows.Forms.TextBox();
            this.lblMatLvl = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblManufac = new System.Windows.Forms.Label();
            this.lblMatType = new System.Windows.Forms.Label();
            this.lblMatNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMatLvl
            // 
            this.cbMatLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatLvl.FormattingEnabled = true;
            this.cbMatLvl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbMatLvl.Items.AddRange(new object[] {
            "원재료",
            "반제품",
            "완제품"});
            this.cbMatLvl.Location = new System.Drawing.Point(353, 79);
            this.cbMatLvl.Name = "cbMatLvl";
            this.cbMatLvl.Size = new System.Drawing.Size(121, 20);
            this.cbMatLvl.TabIndex = 41;
            // 
            // tbManufac
            // 
            this.tbManufac.Location = new System.Drawing.Point(126, 116);
            this.tbManufac.Name = "tbManufac";
            this.tbManufac.Size = new System.Drawing.Size(121, 21);
            this.tbManufac.TabIndex = 40;
            // 
            // cbOfferer
            // 
            this.cbOfferer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOfferer.FormattingEnabled = true;
            this.cbOfferer.Location = new System.Drawing.Point(353, 153);
            this.cbOfferer.Name = "cbOfferer";
            this.cbOfferer.Size = new System.Drawing.Size(121, 20);
            this.cbOfferer.TabIndex = 39;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(399, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbMatType
            // 
            this.cbMatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatType.FormattingEnabled = true;
            this.cbMatType.Location = new System.Drawing.Point(126, 41);
            this.cbMatType.Name = "cbMatType";
            this.cbMatType.Size = new System.Drawing.Size(121, 20);
            this.cbMatType.TabIndex = 36;
            // 
            // lblOfferer
            // 
            this.lblOfferer.AutoSize = true;
            this.lblOfferer.Location = new System.Drawing.Point(277, 156);
            this.lblOfferer.Name = "lblOfferer";
            this.lblOfferer.Size = new System.Drawing.Size(41, 12);
            this.lblOfferer.TabIndex = 35;
            this.lblOfferer.Text = "공급사";
            // 
            // lblMatEa
            // 
            this.lblMatEa.AutoSize = true;
            this.lblMatEa.Location = new System.Drawing.Point(277, 119);
            this.lblMatEa.Name = "lblMatEa";
            this.lblMatEa.Size = new System.Drawing.Size(41, 12);
            this.lblMatEa.TabIndex = 34;
            this.lblMatEa.Text = "입고량";
            // 
            // tbMatEa
            // 
            this.tbMatEa.Location = new System.Drawing.Point(353, 116);
            this.tbMatEa.Name = "tbMatEa";
            this.tbMatEa.Size = new System.Drawing.Size(121, 21);
            this.tbMatEa.TabIndex = 33;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(353, 41);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(121, 21);
            this.tbCost.TabIndex = 32;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 153);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 21);
            this.tbName.TabIndex = 31;
            // 
            // tbMatNo
            // 
            this.tbMatNo.Location = new System.Drawing.Point(126, 78);
            this.tbMatNo.Name = "tbMatNo";
            this.tbMatNo.Size = new System.Drawing.Size(121, 21);
            this.tbMatNo.TabIndex = 30;
            // 
            // lblMatLvl
            // 
            this.lblMatLvl.AutoSize = true;
            this.lblMatLvl.Location = new System.Drawing.Point(261, 82);
            this.lblMatLvl.Name = "lblMatLvl";
            this.lblMatLvl.Size = new System.Drawing.Size(57, 12);
            this.lblMatLvl.TabIndex = 29;
            this.lblMatLvl.Text = "자재 단계";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(289, 44);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(29, 12);
            this.lblCost.TabIndex = 28;
            this.lblCost.Text = "단가";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "자재명";
            // 
            // lblManufac
            // 
            this.lblManufac.AutoSize = true;
            this.lblManufac.Location = new System.Drawing.Point(50, 119);
            this.lblManufac.Name = "lblManufac";
            this.lblManufac.Size = new System.Drawing.Size(41, 12);
            this.lblManufac.TabIndex = 26;
            this.lblManufac.Text = "제조사";
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Location = new System.Drawing.Point(34, 44);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(57, 12);
            this.lblMatType.TabIndex = 25;
            this.lblMatType.Text = "자재 분류";
            // 
            // lblMatNo
            // 
            this.lblMatNo.AutoSize = true;
            this.lblMatNo.Location = new System.Drawing.Point(34, 81);
            this.lblMatNo.Name = "lblMatNo";
            this.lblMatNo.Size = new System.Drawing.Size(57, 12);
            this.lblMatNo.TabIndex = 24;
            this.lblMatNo.Text = "자재 번호";
            // 
            // CtrlMatAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMatLvl);
            this.Controls.Add(this.tbManufac);
            this.Controls.Add(this.cbOfferer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbMatType);
            this.Controls.Add(this.lblOfferer);
            this.Controls.Add(this.lblMatEa);
            this.Controls.Add(this.tbMatEa);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMatNo);
            this.Controls.Add(this.lblMatLvl);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblManufac);
            this.Controls.Add(this.lblMatType);
            this.Controls.Add(this.lblMatNo);
            this.Name = "CtrlMatAdd";
            this.Size = new System.Drawing.Size(509, 261);
            this.Load += new System.EventHandler(this.CtrlMatAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMatLvl;
        private System.Windows.Forms.TextBox tbManufac;
        private System.Windows.Forms.ComboBox cbOfferer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbMatType;
        private System.Windows.Forms.Label lblOfferer;
        private System.Windows.Forms.Label lblMatEa;
        private System.Windows.Forms.TextBox tbMatEa;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMatNo;
        private System.Windows.Forms.Label lblMatLvl;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManufac;
        private System.Windows.Forms.Label lblMatType;
        private System.Windows.Forms.Label lblMatNo;
    }
}
