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
        private BindingList<SearchModel> KeywordList { get; set; } = new BindingList<SearchModel>();
        private List<string> SearchExts { get; set; } = new List<string>() { ".txt", ".sql", ".prc", ".pls", ".fnc" };
        public SearchForm()
        {
            InitializeComponent();
            rbAnd.Click += RbAnd_Click;
            rbOr.Click += RbAnd_Click;
            rbStart.Click += RbAnd_Click;
            rbEnd.Click += RbAnd_Click;
        }

        private void RbAnd_Click(object sender, EventArgs e)
        {
            string senderName = (sender as RadioButton).Name;
            Console.WriteLine(senderName);

            if (senderName == nameof(rbStart) || senderName == nameof(rbEnd))
                InitSearchList(1);
            else
                InitSearchList();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            txtExt.Text = string.Join(",", SearchExts);
            InitSearchList();
            gvKW.DataSource = KeywordList;
        }

        private void btnSelSrc_Click(object sender, EventArgs e)
        {
            txtSrcPath.Text = FileUtility.OpenFolderDialog();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            SearchExts = txtExt.Text.Split(',').Select(x => x.Trim()).ToList();

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
                                .Where(s => SearchExts.Contains(Path.GetExtension(s).ToLower()));

                WriteLog("掃檔中......");

                Parallel.ForEach(filePaths, path =>
                {
                    try
                    {
                        string content = File.ReadAllText(path, Encoding.Default).ToLower();
                        int findCnt = 0;

                        keywords.ForEach(word =>
                        {
                            if (rbStart.Checked)
                            {
                                if (content.StartsWith(word)) findCnt++;
                            }
                            else if (rbEnd.Checked)
                            {
                                if (content.EndsWith(word)) findCnt++;
                            }
                            else
                            {
                                if (content.Contains(word)) findCnt++;
                            }
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
                if (!string.IsNullOrWhiteSpace(item.Keyword))
                {
                    result.Add(item.Keyword.ToLower().Trim());
                }
            }
            return result;
        }

        private void InitSearchList(int count = 10)
        {
            KeywordList.Clear();

            for (int i = 0; i < count; i++)
            {
                KeywordList.Add(new SearchModel());
            }


            gvKW.Refresh();
        }

        private void WriteLog(string msg)
        {
            this.BeginInvoke((Action)(() => {
                txtResult.AppendText(msg);
                txtResult.AppendText(Environment.NewLine);
            }));
        }

    }


    public class SearchModel
    {
        public string Keyword { get; set; }

        public SearchModel(string text = "")
        {
            Keyword = text;
        }
    }
}
