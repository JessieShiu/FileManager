namespace FileManager
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
            this.btnSelDest = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "來源資料夾";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "目的資料夾";
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(310, 9);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.Size = new System.Drawing.Size(605, 29);
            this.txtSrcPath.TabIndex = 2;
            // 
            // txtDestPath
            // 
            this.txtDestPath.Location = new System.Drawing.Point(310, 44);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.Size = new System.Drawing.Size(605, 29);
            this.txtDestPath.TabIndex = 3;
            // 
            // btnSelSrc
            // 
            this.btnSelSrc.Location = new System.Drawing.Point(921, 9);
            this.btnSelSrc.Name = "btnSelSrc";
            this.btnSelSrc.Size = new System.Drawing.Size(75, 26);
            this.btnSelSrc.TabIndex = 4;
            this.btnSelSrc.Text = "選取";
            this.btnSelSrc.UseVisualStyleBackColor = true;
            this.btnSelSrc.Click += new System.EventHandler(this.btnSelSrc_Click);
            // 
            // btnSelDest
            // 
            this.btnSelDest.Location = new System.Drawing.Point(921, 44);
            this.btnSelDest.Name = "btnSelDest";
            this.btnSelDest.Size = new System.Drawing.Size(75, 26);
            this.btnSelDest.TabIndex = 5;
            this.btnSelDest.Text = "選取";
            this.btnSelDest.UseVisualStyleBackColor = true;
            this.btnSelDest.Click += new System.EventHandler(this.btnSelDest_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(219, 111);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(775, 613);
            this.txtResult.TabIndex = 6;
            // 
            // txtPackage
            // 
            this.txtPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPackage.Location = new System.Drawing.Point(12, 41);
            this.txtPackage.Multiline = true;
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPackage.Size = new System.Drawing.Size(189, 683);
            this.txtPackage.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "安裝包清單";
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(876, 79);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(120, 26);
            this.btnMerge.TabIndex = 9;
            this.btnMerge.Text = "產生盤點包";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 736);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPackage);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSelDest);
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
        private System.Windows.Forms.Button btnSelDest;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMerge;
    }
}

