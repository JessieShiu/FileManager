namespace MesFileTool
{
    partial class MDIParent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStripItem_Merge = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItem_fileSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItem_SPBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItem_ExecSql = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItem_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItem_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStripItem_FileList = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel.Text = "狀態";
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripItem_Merge,
            this.MenuStripItem_fileSearch,
            this.MenuStripItem_SPBackup,
            this.MenuStripItem_ExecSql,
            this.MenuStripItem_FileList});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1008, 32);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // MenuStripItem_Merge
            // 
            this.MenuStripItem_Merge.Image = global::MesFileTool.Properties.Resources.folder;
            this.MenuStripItem_Merge.Name = "MenuStripItem_Merge";
            this.MenuStripItem_Merge.Size = new System.Drawing.Size(117, 24);
            this.MenuStripItem_Merge.Text = "盤點包工具";
            this.MenuStripItem_Merge.Click += new System.EventHandler(this.MenuStripItem_Merge_Click);
            // 
            // MenuStripItem_fileSearch
            // 
            this.MenuStripItem_fileSearch.Image = global::MesFileTool.Properties.Resources.search;
            this.MenuStripItem_fileSearch.Name = "MenuStripItem_fileSearch";
            this.MenuStripItem_fileSearch.Size = new System.Drawing.Size(133, 24);
            this.MenuStripItem_fileSearch.Text = "檔案內容搜尋";
            this.MenuStripItem_fileSearch.Click += new System.EventHandler(this.MenuStripItem_fileSearch_Click);
            // 
            // MenuStripItem_SPBackup
            // 
            this.MenuStripItem_SPBackup.Image = global::MesFileTool.Properties.Resources.database;
            this.MenuStripItem_SPBackup.Name = "MenuStripItem_SPBackup";
            this.MenuStripItem_SPBackup.Size = new System.Drawing.Size(88, 24);
            this.MenuStripItem_SPBackup.Text = "SP備份";
            this.MenuStripItem_SPBackup.Click += new System.EventHandler(this.MenuStripItem_SPBackup_Click);
            // 
            // MenuStripItem_ExecSql
            // 
            this.MenuStripItem_ExecSql.Image = global::MesFileTool.Properties.Resources.sql_icon;
            this.MenuStripItem_ExecSql.Name = "MenuStripItem_ExecSql";
            this.MenuStripItem_ExecSql.Size = new System.Drawing.Size(99, 24);
            this.MenuStripItem_ExecSql.Text = "SQL執行";
            // 
            // MenuStripItem_Update
            // 
            this.MenuStripItem_Update.Name = "MenuStripItem_Update";
            this.MenuStripItem_Update.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuStripItem_Search
            // 
            this.MenuStripItem_Search.Name = "MenuStripItem_Search";
            this.MenuStripItem_Search.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuStripItem_FileList
            // 
            this.MenuStripItem_FileList.Name = "MenuStripItem_FileList";
            this.MenuStripItem_FileList.Size = new System.Drawing.Size(85, 24);
            this.MenuStripItem_FileList.Text = "檔案列表";
            this.MenuStripItem_FileList.Click += new System.EventHandler(this.MenuStripItem_FileList_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIParent";
            this.Text = "KH MES Tool";
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_Update;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_Merge;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_SPBackup;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_Search;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_fileSearch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_ExecSql;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_FileList;
    }
}



