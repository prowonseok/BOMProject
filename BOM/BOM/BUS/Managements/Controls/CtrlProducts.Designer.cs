namespace BOM.BUS.Managements.Controls
{
    partial class CtrlProducts
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
            this.cbMatType = new System.Windows.Forms.ComboBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.btnImgSearch = new System.Windows.Forms.Button();
            this.pbProImg = new System.Windows.Forms.PictureBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMatType = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbSpec = new System.Windows.Forms.GroupBox();
            this.lblCOOLER = new System.Windows.Forms.Label();
            this.lblCASE = new System.Windows.Forms.Label();
            this.lblPSU = new System.Windows.Forms.Label();
            this.lblSSD = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblVGA = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.cbCOOLER = new System.Windows.Forms.ComboBox();
            this.cbCASE = new System.Windows.Forms.ComboBox();
            this.cbPSU = new System.Windows.Forms.ComboBox();
            this.cbSSD = new System.Windows.Forms.ComboBox();
            this.cbHDD = new System.Windows.Forms.ComboBox();
            this.cbRAM = new System.Windows.Forms.ComboBox();
            this.cbVGA = new System.Windows.Forms.ComboBox();
            this.cbMB = new System.Windows.Forms.ComboBox();
            this.cbCPU = new System.Windows.Forms.ComboBox();
            this.ofdProImg = new System.Windows.Forms.OpenFileDialog();
            this.tbMatNo = new System.Windows.Forms.TextBox();
            this.lblMatNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProImg)).BeginInit();
            this.gbSpec.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMatType
            // 
            this.cbMatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatType.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbMatType.FormattingEnabled = true;
            this.cbMatType.Location = new System.Drawing.Point(26, 38);
            this.cbMatType.Name = "cbMatType";
            this.cbMatType.Size = new System.Drawing.Size(121, 23);
            this.cbMatType.TabIndex = 47;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblImg.Location = new System.Drawing.Point(24, 206);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(43, 15);
            this.lblImg.TabIndex = 45;
            this.lblImg.Text = "이미지";
            // 
            // btnImgSearch
            // 
            this.btnImgSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnImgSearch.Location = new System.Drawing.Point(26, 436);
            this.btnImgSearch.Name = "btnImgSearch";
            this.btnImgSearch.Size = new System.Drawing.Size(75, 23);
            this.btnImgSearch.TabIndex = 44;
            this.btnImgSearch.Text = "찾아보기";
            this.btnImgSearch.UseVisualStyleBackColor = true;
            this.btnImgSearch.Click += new System.EventHandler(this.btnImgSearch_Click);
            // 
            // pbProImg
            // 
            this.pbProImg.Location = new System.Drawing.Point(26, 221);
            this.pbProImg.Name = "pbProImg";
            this.pbProImg.Size = new System.Drawing.Size(224, 209);
            this.pbProImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProImg.TabIndex = 43;
            this.pbProImg.TabStop = false;
            // 
            // tbSpec
            // 
            this.tbSpec.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSpec.Location = new System.Drawing.Point(275, 38);
            this.tbSpec.Multiline = true;
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(308, 401);
            this.tbSpec.TabIndex = 42;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbName.Location = new System.Drawing.Point(26, 171);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 41;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPrice.Location = new System.Drawing.Point(26, 127);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 23);
            this.tbPrice.TabIndex = 40;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(24, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "제품명";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrice.Location = new System.Drawing.Point(24, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 15);
            this.lblPrice.TabIndex = 38;
            this.lblPrice.Text = "가격";
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatType.Location = new System.Drawing.Point(24, 23);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(59, 15);
            this.lblMatType.TabIndex = 37;
            this.lblMatType.Text = "제품 분류";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSubmit.Location = new System.Drawing.Point(749, 436);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "등록";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbSpec
            // 
            this.gbSpec.Controls.Add(this.lblCOOLER);
            this.gbSpec.Controls.Add(this.lblCASE);
            this.gbSpec.Controls.Add(this.lblPSU);
            this.gbSpec.Controls.Add(this.lblSSD);
            this.gbSpec.Controls.Add(this.lblHDD);
            this.gbSpec.Controls.Add(this.lblRAM);
            this.gbSpec.Controls.Add(this.lblVGA);
            this.gbSpec.Controls.Add(this.lblMB);
            this.gbSpec.Controls.Add(this.lblCPU);
            this.gbSpec.Controls.Add(this.cbCOOLER);
            this.gbSpec.Controls.Add(this.cbCASE);
            this.gbSpec.Controls.Add(this.cbPSU);
            this.gbSpec.Controls.Add(this.cbSSD);
            this.gbSpec.Controls.Add(this.cbHDD);
            this.gbSpec.Controls.Add(this.cbRAM);
            this.gbSpec.Controls.Add(this.cbVGA);
            this.gbSpec.Controls.Add(this.cbMB);
            this.gbSpec.Controls.Add(this.cbCPU);
            this.gbSpec.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSpec.Location = new System.Drawing.Point(256, 18);
            this.gbSpec.Name = "gbSpec";
            this.gbSpec.Size = new System.Drawing.Size(475, 441);
            this.gbSpec.TabIndex = 46;
            this.gbSpec.TabStop = false;
            this.gbSpec.Text = "제품 사양";
            // 
            // lblCOOLER
            // 
            this.lblCOOLER.AutoSize = true;
            this.lblCOOLER.Location = new System.Drawing.Point(344, 379);
            this.lblCOOLER.Name = "lblCOOLER";
            this.lblCOOLER.Size = new System.Drawing.Size(53, 15);
            this.lblCOOLER.TabIndex = 33;
            this.lblCOOLER.Text = "COOLER";
            // 
            // lblCASE
            // 
            this.lblCASE.AutoSize = true;
            this.lblCASE.Location = new System.Drawing.Point(344, 335);
            this.lblCASE.Name = "lblCASE";
            this.lblCASE.Size = new System.Drawing.Size(36, 15);
            this.lblCASE.TabIndex = 32;
            this.lblCASE.Text = "CASE";
            // 
            // lblPSU
            // 
            this.lblPSU.AutoSize = true;
            this.lblPSU.Location = new System.Drawing.Point(344, 291);
            this.lblPSU.Name = "lblPSU";
            this.lblPSU.Size = new System.Drawing.Size(30, 15);
            this.lblPSU.TabIndex = 31;
            this.lblPSU.Text = "PSU";
            // 
            // lblSSD
            // 
            this.lblSSD.AutoSize = true;
            this.lblSSD.Location = new System.Drawing.Point(344, 247);
            this.lblSSD.Name = "lblSSD";
            this.lblSSD.Size = new System.Drawing.Size(30, 15);
            this.lblSSD.TabIndex = 30;
            this.lblSSD.Text = "SSD";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Location = new System.Drawing.Point(344, 203);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(34, 15);
            this.lblHDD.TabIndex = 29;
            this.lblHDD.Text = "HDD";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(341, 159);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(35, 15);
            this.lblRAM.TabIndex = 28;
            this.lblRAM.Text = "RAM";
            // 
            // lblVGA
            // 
            this.lblVGA.AutoSize = true;
            this.lblVGA.Location = new System.Drawing.Point(343, 115);
            this.lblVGA.Name = "lblVGA";
            this.lblVGA.Size = new System.Drawing.Size(32, 15);
            this.lblVGA.TabIndex = 27;
            this.lblVGA.Text = "VGA";
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(343, 68);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(32, 15);
            this.lblMB.TabIndex = 26;
            this.lblMB.Text = "M/B";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(341, 24);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(31, 15);
            this.lblCPU.TabIndex = 25;
            this.lblCPU.Text = "CPU";
            // 
            // cbCOOLER
            // 
            this.cbCOOLER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCOOLER.FormattingEnabled = true;
            this.cbCOOLER.Location = new System.Drawing.Point(345, 394);
            this.cbCOOLER.Name = "cbCOOLER";
            this.cbCOOLER.Size = new System.Drawing.Size(121, 23);
            this.cbCOOLER.TabIndex = 24;
            // 
            // cbCASE
            // 
            this.cbCASE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCASE.FormattingEnabled = true;
            this.cbCASE.Location = new System.Drawing.Point(345, 350);
            this.cbCASE.Name = "cbCASE";
            this.cbCASE.Size = new System.Drawing.Size(121, 23);
            this.cbCASE.TabIndex = 23;
            // 
            // cbPSU
            // 
            this.cbPSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPSU.FormattingEnabled = true;
            this.cbPSU.Location = new System.Drawing.Point(345, 306);
            this.cbPSU.Name = "cbPSU";
            this.cbPSU.Size = new System.Drawing.Size(121, 23);
            this.cbPSU.TabIndex = 22;
            // 
            // cbSSD
            // 
            this.cbSSD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSSD.FormattingEnabled = true;
            this.cbSSD.Location = new System.Drawing.Point(345, 262);
            this.cbSSD.Name = "cbSSD";
            this.cbSSD.Size = new System.Drawing.Size(121, 23);
            this.cbSSD.TabIndex = 21;
            // 
            // cbHDD
            // 
            this.cbHDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHDD.FormattingEnabled = true;
            this.cbHDD.Location = new System.Drawing.Point(345, 218);
            this.cbHDD.Name = "cbHDD";
            this.cbHDD.Size = new System.Drawing.Size(121, 23);
            this.cbHDD.TabIndex = 20;
            // 
            // cbRAM
            // 
            this.cbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRAM.FormattingEnabled = true;
            this.cbRAM.Location = new System.Drawing.Point(345, 174);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(121, 23);
            this.cbRAM.TabIndex = 19;
            // 
            // cbVGA
            // 
            this.cbVGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVGA.FormattingEnabled = true;
            this.cbVGA.Location = new System.Drawing.Point(345, 130);
            this.cbVGA.Name = "cbVGA";
            this.cbVGA.Size = new System.Drawing.Size(121, 23);
            this.cbVGA.TabIndex = 18;
            // 
            // cbMB
            // 
            this.cbMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMB.FormattingEnabled = true;
            this.cbMB.Location = new System.Drawing.Point(345, 86);
            this.cbMB.Name = "cbMB";
            this.cbMB.Size = new System.Drawing.Size(121, 23);
            this.cbMB.TabIndex = 17;
            // 
            // cbCPU
            // 
            this.cbCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPU.FormattingEnabled = true;
            this.cbCPU.Location = new System.Drawing.Point(345, 42);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(121, 23);
            this.cbCPU.TabIndex = 16;
            // 
            // ofdProImg
            // 
            this.ofdProImg.FileName = "openFileDialog1";
            // 
            // tbMatNo
            // 
            this.tbMatNo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbMatNo.Location = new System.Drawing.Point(26, 83);
            this.tbMatNo.Name = "tbMatNo";
            this.tbMatNo.Size = new System.Drawing.Size(100, 23);
            this.tbMatNo.TabIndex = 49;
            // 
            // lblMatNo
            // 
            this.lblMatNo.AutoSize = true;
            this.lblMatNo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatNo.Location = new System.Drawing.Point(24, 68);
            this.lblMatNo.Name = "lblMatNo";
            this.lblMatNo.Size = new System.Drawing.Size(59, 15);
            this.lblMatNo.TabIndex = 48;
            this.lblMatNo.Text = "제품 번호";
            // 
            // CtrlProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbMatNo);
            this.Controls.Add(this.lblMatNo);
            this.Controls.Add(this.cbMatType);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.btnImgSearch);
            this.Controls.Add(this.pbProImg);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMatType);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbSpec);
            this.Name = "CtrlProducts";
            this.Size = new System.Drawing.Size(839, 482);
            this.Load += new System.EventHandler(this.CtrlProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProImg)).EndInit();
            this.gbSpec.ResumeLayout(false);
            this.gbSpec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMatType;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Button btnImgSearch;
        private System.Windows.Forms.PictureBox pbProImg;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMatType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbSpec;
        private System.Windows.Forms.Label lblCOOLER;
        private System.Windows.Forms.Label lblCASE;
        private System.Windows.Forms.Label lblPSU;
        private System.Windows.Forms.Label lblSSD;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblVGA;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ComboBox cbCOOLER;
        private System.Windows.Forms.ComboBox cbCASE;
        private System.Windows.Forms.ComboBox cbPSU;
        private System.Windows.Forms.ComboBox cbSSD;
        private System.Windows.Forms.ComboBox cbHDD;
        private System.Windows.Forms.ComboBox cbRAM;
        private System.Windows.Forms.ComboBox cbVGA;
        private System.Windows.Forms.ComboBox cbMB;
        private System.Windows.Forms.ComboBox cbCPU;
        private System.Windows.Forms.OpenFileDialog ofdProImg;
        private System.Windows.Forms.TextBox tbMatNo;
        private System.Windows.Forms.Label lblMatNo;
    }
}
