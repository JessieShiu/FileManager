using MesFileTool.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesFileTool
{
    public partial class FileList : Form
    {
        public FileList()
        {
            InitializeComponent();
        }

        private void FileList_Load(object sender, EventArgs e)
        {
            groupBox1.Paint += GroupBox_Paint;
            groupBox2.Paint += GroupBox_Paint;
            groupBox3.Paint += GroupBox_Paint;
        }

        private void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox gBox = (GroupBox)sender;

            e.Graphics.Clear(gBox.BackColor);
            e.Graphics.DrawString(gBox.Text, gBox.Font, Brushes.DarkBlue, 10, 1);
            var vSize = e.Graphics.MeasureString(gBox.Text, gBox.Font);
            e.Graphics.DrawLine(Pens.DarkGray, 1, vSize.Height / 2, 8, vSize.Height / 2);
            e.Graphics.DrawLine(Pens.DarkGray, vSize.Width + 8, vSize.Height / 2, gBox.Width - 2, vSize.Height / 2);
            e.Graphics.DrawLine(Pens.DarkGray, 1, vSize.Height / 2, 1, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.DarkGray, 1, gBox.Height - 2, gBox.Width - 2, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.DarkGray, gBox.Width - 2, vSize.Height / 2, gBox.Width - 2, gBox.Height - 2);
        }

        private void btnSelSrc_Click(object sender, EventArgs e)
        {
            var path = FileUtility.OpenFolderDialog();
            if (!string.IsNullOrWhiteSpace(path))
                txtPath.Text = path;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string srcPath = txtPath.Text.Trim();

            if (string.IsNullOrEmpty(srcPath))
            {
                MessageBox.Show("選路徑!");
                return;
            }

            List<string> paths = new List<string>();
            SearchOption searchOption = rb_TopOnly.Checked ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories;
            if (rb_folder.Checked)
            {
                paths = Directory.GetDirectories(txtPath.Text, "*", searchOption).ToList();
            }
            else
            {
                paths = Directory.GetFiles(txtPath.Text, "*.*", searchOption).ToList();
            }


            List<ListModel> result = paths.Select(f =>
            {
                var rtn = new ListModel
                {
                    FullPath = rb_opt_FullPath.Checked ? f : (rb_opt_fileName.Checked ? Path.GetFileName(f) : Path.GetFileNameWithoutExtension(f)),
                };

                //解析檔名
                if (!rb_opt_fileName.Checked)
                {
                    var fName = Path.GetFileNameWithoutExtension(f);

                    if (fName.Contains('.'))
                        fName = fName.Split('.')[1];

                    rtn.ObjectName = ConverFileName(fName);
                }

                return rtn;
            }).ToList();

            dgvResult.DataSource = result;
            dgvResult.Refresh();
        }

        private string ConverFileName(string input)
        {
            try
            {
                return Regex.Replace(input, @"(_)(\d{4})(\d{2})(\d{2})", "", RegexOptions.None);
            }
            catch (Exception)
            {
                return input;
            }
        }
    }

    public class ListModel
    {
        public string FullPath { get; set; }
        public string ObjectName { get; set; }
    }
}
