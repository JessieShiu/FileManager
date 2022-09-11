using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesFileTool
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();           
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            Text += $"〔 beta {FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion}〕";
            ShowChildForm(new MergeForm(), MenuStripItem_Merge.Text);
        }

        private void MenuStripItem_Merge_Click(object sender, EventArgs e)
        {
            ShowChildForm(new MergeForm(), (sender as ToolStripMenuItem).Text);
        }

        private void MenuStripItem_fileSearch_Click(object sender, EventArgs e)
        {
            ShowChildForm(new SearchForm(), (sender as ToolStripMenuItem).Text);
        }

        private void MenuStripItem_SPBackup_Click(object sender, EventArgs e)
        {
            ShowChildForm(new DBBackupForm(), (sender as ToolStripMenuItem).Text);
        }

        private void ShowChildForm(Form form, string title)
        {
            bool isExist = CheckFormExist(form.Name);
            if (!isExist)
            {
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Text = title;
                //form.FormBorderStyle = FormBorderStyle.None;
                form.Show();
            }
        }


        /// <summary>
        /// 檢查子表單是否存在
        /// </summary>
        /// <param name="FormText">Form.Text</param>
        /// <returns></returns>
        private bool CheckFormExist(string formName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(formName))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return true;
                }
            }
            return false;
        }

        private void MenuStripItem_FileList_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FileList(), (sender as ToolStripMenuItem).Text);
        }
    }
}
