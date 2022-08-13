namespace MesFileTool
{
    partial class SearchForm
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
            this.btnSelSrc = new System.Windows.Forms.Button();
            this.txtSrcPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gvKW = new System.Windows.Forms.DataGridView();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.Keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvKW)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelSrc
            // 
            this.btnSelSrc.Location = new System.Drawing.Point(819, 11);
            this.btnSelSrc.Name = "btnSelSrc";
            this.btnSelSrc.Size = new System.Drawing.Size(71, 30);
            this.btnSelSrc.TabIndex = 7;
            this.btnSelSrc.Text = "選取";
            this.btnSelSrc.UseVisualStyleBackColor = true;
            this.btnSelSrc.Click += new System.EventHandler(this.btnSelSrc_Click);
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(120, 12);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.Size = new System.Drawing.Size(693, 29);
            this.txtSrcPath.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "資料夾路徑";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "訊息";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(258, 105);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(738, 444);
            this.txtResult.TabIndex = 12;
            // 
            // gvKW
            // 
            this.gvKW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gvKW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Keyword});
            this.gvKW.Location = new System.Drawing.Point(12, 105);
            this.gvKW.Name = "gvKW";
            this.gvKW.RowTemplate.Height = 24;
            this.gvKW.Size = new System.Drawing.Size(240, 444);
            this.gvKW.TabIndex = 15;
            // 
            // rbAnd
            // 
            this.rbAnd.AutoSize = true;
            this.rbAnd.Checked = true;
            this.rbAnd.Location = new System.Drawing.Point(13, 80);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(63, 24);
            this.rbAnd.TabIndex = 16;
            this.rbAnd.TabStop = true;
            this.rbAnd.Text = "AND";
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // rbOr
            // 
            this.rbOr.AutoSize = true;
            this.rbOr.Location = new System.Drawing.Point(92, 80);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(50, 24);
            this.rbOr.TabIndex = 17;
            this.rbOr.Text = "OR";
            this.rbOr.UseVisualStyleBackColor = true;
            // 
            // Keyword
            // 
            this.Keyword.DataPropertyName = "Keyword";
            this.Keyword.HeaderText = "關鍵字";
            this.Keyword.Name = "Keyword";
            this.Keyword.Width = 190;
            // 
            // btnExec
            // 
            this.btnExec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExec.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExec.Location = new System.Drawing.Point(896, 11);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(100, 67);
            this.btnExec.TabIndex = 18;
            this.btnExec.Text = "搜尋";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(301, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "(檔案多、檔案大可能會很久)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "可搜尋副檔名";
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(120, 49);
            this.txtExt.Name = "txtExt";
            this.txtExt.ReadOnly = true;
            this.txtExt.Size = new System.Drawing.Size(693, 29);
            this.txtExt.TabIndex = 21;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.rbOr);
            this.Controls.Add(this.rbAnd);
            this.Controls.Add(this.gvKW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSelSrc);
            this.Controls.Add(this.txtSrcPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchForm";
            this.Text = "檔案內容搜尋";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelSrc;
        private System.Windows.Forms.TextBox txtSrcPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataGridView gvKW;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keyword;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExt;
    }
}