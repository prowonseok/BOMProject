﻿namespace BOM.BUS.Sales
{
    partial class Shipment
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
            this.dgvProList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAddr = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtconf = new System.Windows.Forms.TextBox();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCus = new System.Windows.Forms.Label();
            this.lblFactory = new System.Windows.Forms.Label();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProList
            // 
            this.dgvProList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProList.Location = new System.Drawing.Point(57, 233);
            this.dgvProList.Name = "dgvProList";
            this.dgvProList.RowTemplate.Height = 23;
            this.dgvProList.Size = new System.Drawing.Size(531, 169);
            this.dgvProList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "거래처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "담당자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "출하창고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "연락처";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "출하예정일";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "주소";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "확인";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "주소변경";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(125, 150);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(40, 12);
            this.lblAddr.TabIndex = 13;
            this.lblAddr.Text = "imsi\\";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "판매조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtconf
            // 
            this.txtconf.Location = new System.Drawing.Point(435, 190);
            this.txtconf.Name = "txtconf";
            this.txtconf.Size = new System.Drawing.Size(153, 21);
            this.txtconf.TabIndex = 15;
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(125, 87);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(40, 12);
            this.lblEmp.TabIndex = 16;
            this.lblEmp.Text = "imsi\\";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(125, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 12);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "imsi\\";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(125, 118);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(40, 12);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "imsi\\";
            // 
            // lblCus
            // 
            this.lblCus.AutoSize = true;
            this.lblCus.Location = new System.Drawing.Point(449, 56);
            this.lblCus.Name = "lblCus";
            this.lblCus.Size = new System.Drawing.Size(40, 12);
            this.lblCus.TabIndex = 19;
            this.lblCus.Text = "imsi\\";
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Location = new System.Drawing.Point(449, 87);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(40, 12);
            this.lblFactory.TabIndex = 20;
            this.lblFactory.Text = "imsi\\";
            // 
            // lblShipDate
            // 
            this.lblShipDate.AutoSize = true;
            this.lblShipDate.Location = new System.Drawing.Point(449, 118);
            this.lblShipDate.Name = "lblShipDate";
            this.lblShipDate.Size = new System.Drawing.Size(40, 12);
            this.lblShipDate.TabIndex = 21;
            this.lblShipDate.Text = "imsi\\";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "주문번호";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(125, 24);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(40, 12);
            this.lblOrderNo.TabIndex = 23;
            this.lblOrderNo.Text = "imsi\\";
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblShipDate);
            this.Controls.Add(this.lblFactory);
            this.Controls.Add(this.lblCus);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.txtconf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProList);
            this.Name = "Shipment";
            this.Text = "Shipment";
            this.Load += new System.EventHandler(this.Shipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtconf;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCus;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.Label lblShipDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrderNo;
    }
}