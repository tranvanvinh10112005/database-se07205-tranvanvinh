﻿namespace SaleManagementWinform
{
    partial class UpdateProduct
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_price = new System.Windows.Forms.TextBox();
            this.txb_amount = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_price
            // 
            this.txb_price.Location = new System.Drawing.Point(164, 273);
            this.txb_price.Multiline = true;
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(281, 38);
            this.txb_price.TabIndex = 17;
            // 
            // txb_amount
            // 
            this.txb_amount.Location = new System.Drawing.Point(164, 214);
            this.txb_amount.Multiline = true;
            this.txb_amount.Name = "txb_amount";
            this.txb_amount.Size = new System.Drawing.Size(281, 38);
            this.txb_amount.TabIndex = 16;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(164, 142);
            this.txb_name.Multiline = true;
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(281, 38);
            this.txb_name.TabIndex = 15;
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(164, 71);
            this.txb_code.Multiline = true;
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(281, 38);
            this.txb_code.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(55, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(55, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(45, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(45, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã sản phẩm";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_price);
            this.Controls.Add(this.txb_amount);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.TextBox txb_amount;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}