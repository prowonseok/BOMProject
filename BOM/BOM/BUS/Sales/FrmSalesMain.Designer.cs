﻿namespace BOM.BUS.Sales
{
    partial class FrmSalesMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalesInquiry = new System.Windows.Forms.Button();
            this.btnChingePrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalesInquiry
            // 
            this.btnSalesInquiry.Location = new System.Drawing.Point(63, 43);
            this.btnSalesInquiry.Name = "btnSalesInquiry";
            this.btnSalesInquiry.Size = new System.Drawing.Size(75, 23);
            this.btnSalesInquiry.TabIndex = 0;
            this.btnSalesInquiry.Text = "판매 조회";
            this.btnSalesInquiry.UseVisualStyleBackColor = true;
            this.btnSalesInquiry.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChingePrice
            // 
            this.btnChingePrice.Location = new System.Drawing.Point(63, 92);
            this.btnChingePrice.Name = "btnChingePrice";
            this.btnChingePrice.Size = new System.Drawing.Size(75, 23);
            this.btnChingePrice.TabIndex = 1;
            this.btnChingePrice.Text = "단가 변경";
            this.btnChingePrice.UseVisualStyleBackColor = true;
            this.btnChingePrice.Click += new System.EventHandler(this.btnChingePrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChingePrice);
            this.Controls.Add(this.btnSalesInquiry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalesInquiry;
        private System.Windows.Forms.Button btnChingePrice;
    }
}

