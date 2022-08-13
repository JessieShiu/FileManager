using MesFileTool.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesFileTool
{
    public partial class SearchForm : Form
    {
        private List<SearchModel> KeywordList { get; set; } = new List<SearchModel>();
        private List<string> searchExts => new List<string>() { ".txt", ".sql" };
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                KeywordList.Add(new SearchModel());
            }

            txtExt.Text = string.Join(",", searchExts);

            gvKW.DataSource = KeywordList;
            gvKW.Refresh();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";

            string srcPath = txtSrcPath.Text.Trim();
            if (string.IsNullOrEmpty(srcPath))
            {
                MessageBox.Show("請先選擇資料夾路徑");
                return;
            }

            var keywords = getKeywords();
            if(keywords.Count == 0)
            {
                MessageBox.Show("請至少輸入一個關鍵字!");
                return;
            }

            WriteLog("讀取資料夾中......");
            btnExec.Enabled = false;

            Task.Factory.StartNew(() =>
            {
                var filePaths = Directory.GetFiles(srcPath, "*.*", SearchOption.AllDirectories)
                                .Where(s => searchExts.Contains(Path.GetExtension(s).ToLower()));

                WriteLog("掃檔中......");

                Parallel.ForEach(filePaths, path =>
                {
                    try
                    {
                        string content = File.ReadAllText(path, Encoding.Default).ToLower();
                        int findCnt = 0;
                        keywords.ForEach(word =>
                        {
                            if (content.Contains(word)) findCnt++;
                        });

                        bool isFind = false;
                        if (rbAnd.Checked) isFind = findCnt == keywords.Count;
                        else isFind = findCnt > 0;

                        if (isFind) WriteLog(path);

                    }
                    catch (Exception ex)
                    {
                        WriteLog($"Error Message=({ex.Message}), {path}");
                    }
                    finally
                    {
                        this.BeginInvoke((Action)(() =>
                        {
                            btnExec.Enabled = true;
                        }));
                    }
                });

                WriteLog("掃檔結束......");
            });
 
        }


        private List<string> getKeywords()
        {
            List<string> result = new List<string>(); 
            foreach (var item in KeywordList)
            {
                if (!string.IsNullOrWhiteSpace(item.keyword))
                {
                    result.Add(item.keyword.ToLower().Trim());
                }
            }
            return result;
        }

        private void WriteLog(string msg)
        {
            this.BeginInvoke((Action)(() => {
                txtResult.AppendText(msg);
                txtResult.AppendText(Environment.NewLine);
            }));
        }

        private void btnSelSrc_Click(object sender, EventArgs e)
        {
           txtSrcPath.Text = FileUtility.OpenFolderDialog();
        }
    }


    public class SearchModel
    {
        public string keyword { get; set; }

        public SearchModel(string text = "")
        {
            keyword = text;
        }
    }
}
