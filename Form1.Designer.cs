﻿namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSrcPath = new System.Windows.Forms.TextBox();
            this.txtDestPath = new System.Windows.Forms.TextBox();
            this.btnSelSrc = new System.Windows.Forms.Button();
            this.btnSelDesc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "來源資料夾";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "目的資料夾";
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(117, 19);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.Size = new System.Drawing.Size(650, 29);
            this.txtSrcPath.TabIndex = 2;
            // 
            // txtDestPath
            // 
            this.txtDestPath.Location = new System.Drawing.Point(117, 63);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.Size = new System.Drawing.Size(650, 29);
            this.txtDestPath.TabIndex = 3;
            // 
            // btnSelSrc
            // 
            this.btnSelSrc.Location = new System.Drawing.Point(773, 16);
            this.btnSelSrc.Name = "btnSelSrc";
            this.btnSelSrc.Size = new System.Drawing.Size(75, 26);
            this.btnSelSrc.TabIndex = 4;
            this.btnSelSrc.Text = "選取";
            this.btnSelSrc.UseVisualStyleBackColor = true;
            this.btnSelSrc.Click += new System.EventHandler(this.btnSelSrc_Click);
            // 
            // btnSelDesc
            // 
            this.btnSelDesc.Location = new System.Drawing.Point(773, 63);
            this.btnSelDesc.Name = "btnSelDesc";
            this.btnSelDesc.Size = new System.Drawing.Size(75, 26);
            this.btnSelDesc.TabIndex = 5;
            this.btnSelDesc.Text = "選取";
            this.btnSelDesc.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 129);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(984, 579);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSelDesc);
            this.Controls.Add(this.btnSelSrc);
            this.Controls.Add(this.txtDestPath);
            this.Controls.Add(this.txtSrcPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSrcPath;
        private System.Windows.Forms.TextBox txtDestPath;
        private System.Windows.Forms.Button btnSelSrc;
        private System.Windows.Forms.Button btnSelDesc;
        private System.Windows.Forms.TextBox textBox1;
    }
}

