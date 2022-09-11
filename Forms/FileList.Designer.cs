namespace MesFileTool
{
    partial class FileList
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.FullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnSelSrc = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_opt_FileNameWithoutExt = new System.Windows.Forms.RadioButton();
            this.rb_opt_FullPath = new System.Windows.Forms.RadioButton();
            this.rb_opt_fileName = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_folder = new System.Windows.Forms.RadioButton();
            this.rb_File = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_TopOnly = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullPath,
            this.ObjectName});
            this.dgvResult.Location = new System.Drawing.Point(12, 162);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(984, 555);
            this.dgvResult.TabIndex = 27;
            // 
            // FullPath
            // 
            this.FullPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullPath.DataPropertyName = "FullPath";
            this.FullPath.HeaderText = "FullPath";
            this.FullPath.Name = "FullPath";
            this.FullPath.ReadOnly = true;
            // 
            // ObjectName
            // 
            this.ObjectName.DataPropertyName = "ObjectName";
            this.ObjectName.HeaderText = "ObjectName";
            this.ObjectName.Name = "ObjectName";
            this.ObjectName.ReadOnly = true;
            this.ObjectName.Width = 300;
            // 
            // btnExec
            // 
            this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExec.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExec.Location = new System.Drawing.Point(896, 11);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(100, 67);
            this.btnExec.TabIndex = 26;
            this.btnExec.Text = "執行";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnSelSrc
            // 
            this.btnSelSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelSrc.Location = new System.Drawing.Point(810, 11);
            this.btnSelSrc.Name = "btnSelSrc";
            this.btnSelSrc.Size = new System.Drawing.Size(52, 30);
            this.btnSelSrc.TabIndex = 25;
            this.btnSelSrc.Text = "選取";
            this.btnSelSrc.UseVisualStyleBackColor = true;
            this.btnSelSrc.Click += new System.EventHandler(this.btnSelSrc_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(111, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(693, 29);
            this.txtPath.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "資料夾路徑";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_opt_FileNameWithoutExt);
            this.groupBox1.Controls.Add(this.rb_opt_FullPath);
            this.groupBox1.Controls.Add(this.rb_opt_fileName);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(458, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 105);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Option";
            // 
            // rb_opt_FileNameWithoutExt
            // 
            this.rb_opt_FileNameWithoutExt.AutoSize = true;
            this.rb_opt_FileNameWithoutExt.Checked = true;
            this.rb_opt_FileNameWithoutExt.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_opt_FileNameWithoutExt.Location = new System.Drawing.Point(19, 80);
            this.rb_opt_FileNameWithoutExt.Name = "rb_opt_FileNameWithoutExt";
            this.rb_opt_FileNameWithoutExt.Size = new System.Drawing.Size(164, 22);
            this.rb_opt_FileNameWithoutExt.TabIndex = 31;
            this.rb_opt_FileNameWithoutExt.TabStop = true;
            this.rb_opt_FileNameWithoutExt.Text = "FileNameWithoutExt";
            this.rb_opt_FileNameWithoutExt.UseVisualStyleBackColor = true;
            // 
            // rb_opt_FullPath
            // 
            this.rb_opt_FullPath.AutoSize = true;
            this.rb_opt_FullPath.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_opt_FullPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_opt_FullPath.Location = new System.Drawing.Point(19, 28);
            this.rb_opt_FullPath.Name = "rb_opt_FullPath";
            this.rb_opt_FullPath.Size = new System.Drawing.Size(80, 22);
            this.rb_opt_FullPath.TabIndex = 30;
            this.rb_opt_FullPath.TabStop = true;
            this.rb_opt_FullPath.Text = "FullPath";
            this.rb_opt_FullPath.UseVisualStyleBackColor = true;
            // 
            // rb_opt_fileName
            // 
            this.rb_opt_fileName.AutoSize = true;
            this.rb_opt_fileName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_opt_fileName.Location = new System.Drawing.Point(19, 54);
            this.rb_opt_fileName.Name = "rb_opt_fileName";
            this.rb_opt_fileName.Size = new System.Drawing.Size(89, 22);
            this.rb_opt_fileName.TabIndex = 29;
            this.rb_opt_fileName.TabStop = true;
            this.rb_opt_fileName.Text = "FileName";
            this.rb_opt_fileName.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_folder);
            this.groupBox2.Controls.Add(this.rb_File);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(239, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 105);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // rb_folder
            // 
            this.rb_folder.AutoSize = true;
            this.rb_folder.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_folder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_folder.Location = new System.Drawing.Point(19, 28);
            this.rb_folder.Name = "rb_folder";
            this.rb_folder.Size = new System.Drawing.Size(68, 22);
            this.rb_folder.TabIndex = 30;
            this.rb_folder.TabStop = true;
            this.rb_folder.Text = "Folder";
            this.rb_folder.UseVisualStyleBackColor = true;
            // 
            // rb_File
            // 
            this.rb_File.AutoSize = true;
            this.rb_File.Checked = true;
            this.rb_File.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_File.Location = new System.Drawing.Point(19, 54);
            this.rb_File.Name = "rb_File";
            this.rb_File.Size = new System.Drawing.Size(49, 22);
            this.rb_File.TabIndex = 29;
            this.rb_File.TabStop = true;
            this.rb_File.Text = "File";
            this.rb_File.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_TopOnly);
            this.groupBox3.Controls.Add(this.rb_All);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(20, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 105);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Option";
            // 
            // rb_TopOnly
            // 
            this.rb_TopOnly.AutoSize = true;
            this.rb_TopOnly.Checked = true;
            this.rb_TopOnly.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_TopOnly.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_TopOnly.Location = new System.Drawing.Point(19, 28);
            this.rb_TopOnly.Name = "rb_TopOnly";
            this.rb_TopOnly.Size = new System.Drawing.Size(144, 22);
            this.rb_TopOnly.TabIndex = 30;
            this.rb_TopOnly.TabStop = true;
            this.rb_TopOnly.Text = "TopDirectoryOnly";
            this.rb_TopOnly.UseVisualStyleBackColor = true;
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_All.Location = new System.Drawing.Point(19, 54);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(109, 22);
            this.rb_All.TabIndex = 29;
            this.rb_All.Text = "All Files/Dirs";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // FileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btnSelSrc);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FileList";
            this.Text = "FileList";
            this.Load += new System.EventHandler(this.FileList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnSelSrc;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_opt_fileName;
        private System.Windows.Forms.RadioButton rb_opt_FileNameWithoutExt;
        private System.Windows.Forms.RadioButton rb_opt_FullPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_folder;
        private System.Windows.Forms.RadioButton rb_File;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_TopOnly;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectName;
    }
}