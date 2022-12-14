namespace MesFileTool
{
    partial class MergeForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "更新包來源";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "目的資料夾";
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(107, 7);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.Size = new System.Drawing.Size(583, 29);
            this.txtSrcPath.TabIndex = 2;
            // 
            // txtDestPath
            // 
            this.txtDestPath.Location = new System.Drawing.Point(107, 41);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.Size = new System.Drawing.Size(583, 29);
            this.txtDestPath.TabIndex = 3;
            // 
            // btnSelSrc
            // 
            this.btnSelSrc.Location = new System.Drawing.Point(696, 7);
            this.btnSelSrc.Name = "btnSelSrc";
            this.btnSelSrc.Size = new System.Drawing.Size(54, 30);
            this.btnSelSrc.TabIndex = 4;
            this.btnSelSrc.Text = "選取";
            this.btnSelSrc.UseVisualStyleBackColor = true;
            this.btnSelSrc.Click += new System.EventHandler(this.btnSelSrc_Click);
            // 
            // btnSelDest
            // 
            this.btnSelDest.Location = new System.Drawing.Point(696, 43);
            this.btnSelDest.Name = "btnSelDest";
            this.btnSelDest.Size = new System.Drawing.Size(54, 30);
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
            this.txtResult.Size = new System.Drawing.Size(777, 438);
            this.txtResult.TabIndex = 6;
            // 
            // txtPackage
            // 
            this.txtPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPackage.Location = new System.Drawing.Point(16, 111);
            this.txtPackage.Multiline = true;
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPackage.Size = new System.Drawing.Size(189, 438);
            this.txtPackage.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "安裝包清單";
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(913, 7);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(83, 63);
            this.btnMerge.TabIndex = 9;
            this.btnMerge.Text = "產生盤點包";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "訊息";
            // 
            // chkCopy
            // 
            this.chkCopy.AutoSize = true;
            this.chkCopy.Checked = true;
            this.chkCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopy.Location = new System.Drawing.Point(759, 7);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new System.Drawing.Size(108, 24);
            this.chkCopy.TabIndex = 12;
            this.chkCopy.Text = "複製更新包";
            this.chkCopy.UseVisualStyleBackColor = true;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Checked = true;
            this.chkCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheck.Location = new System.Drawing.Point(760, 37);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(136, 24);
            this.chkCheck.TabIndex = 13;
            this.chkCheck.Text = "檢查folder名稱";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(760, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "產生Top folder";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImage = global::MesFileTool.Properties.Resources.open_door;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.Location = new System.Drawing.Point(964, 76);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(5);
            this.btnOpen.Size = new System.Drawing.Size(32, 29);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // MergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chkCheck);
            this.Controls.Add(this.chkCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpen);
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
            this.Name = "MergeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "進入神秘區";
            this.Text = "MES更新工具";
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
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCopy;
        private System.Windows.Forms.CheckBox chkCheck;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

