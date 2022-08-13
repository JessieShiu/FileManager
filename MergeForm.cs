//using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using MesFileTool.Utility;

namespace MesFileTool
{
    public partial class MergeForm : Form
    {
        private static bool IsAuth = true;
        private List<string> PackageNameList => txtPackage.Text.Trim().Replace("\r\n", ",").Split(',').OrderBy(x => x).ToList();
        private string DestPath
        {
            get { return txtDestPath.Text.Trim(); }
            set { txtDestPath.Text = value; }
        }
        private string SrcPath
        {
            get { return txtSrcPath.Text.Trim(); }
            set { txtSrcPath.Text = value; }
        }

        /// <summary>
        /// 更新包目錄Path
        /// </summary>
        private string TopPackagePath => Path.Combine(DestPath, "更新包");
        /// <summary>
        /// 彙整包目錄Path
        /// </summary>
        private string TopMergePath => Path.Combine(DestPath, "彙整包");

        /// <summary>
        /// 紀錄更新包內DB資料夾的Path
        /// </summary>
        private List<string> DBFolderPaths { get; set; } = new List<string>();
        /// <summary>
        /// 紀錄更新包資料夾的Path
        /// </summary>
        private List<string> PackageFolders { get; set; } = new List<string>();

        public MergeForm()
        {
            InitializeComponent();

            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.BackColor = Color.Transparent;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnOpen, "進入神秘區");

            
            //DialogForm = new DialogForm();
            //DialogForm.FormClosed += (sender, e) => { };
            //DialogForm.ConfirmBtn.Click += (sender, e) =>
            //{
            //    IsAuth = DialogForm.AuthCode == "admin@123";
            //    if (IsAuth)
            //    {
            //        this.Hide();
            //        DialogForm.Hide();
            //        ShowUpdateForm();
            //    }
            //    else
            //    {
            //        DialogForm.Close();
            //        MessageBox.Show("授權碼錯誤");
            //    }
            //};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SrcPath = ConfigurationManager.AppSettings["SrcPath"];
            DestPath = ConfigurationManager.AppSettings["DestPath"];
            btnMerge.Text = "產生" + Environment.NewLine + "盤點包";
        }
        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (PackageNameList.Count == 0 || string.IsNullOrEmpty(SrcPath) || string.IsNullOrEmpty(DestPath))
            {
                WriteLog("請先輸入：更新包清單、更新包來源、目的資料夾");
                return;
            }
            DBFolderPaths.Clear();
            PackageFolders.Clear();
            txtResult.Text = "";

            Task.Factory.StartNew(() =>
            {
                try
                {
                    if (chkCopy.Checked)
                        CopyPackages();

                    if (chkCheck.Checked && !CheckFolderName())
                        return;

                    MergeFolders();

                    MessageBox.Show("盤點包產生完成!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.BeginInvoke((Action)(() => { EnableForm(true); }));
            });

            EnableForm(false);
        }
        private void btnSelSrc_Click(object sender, EventArgs e)
        {
            SrcPath = FileUtility.OpenFolderDialog(SrcPath);
            if (!string.IsNullOrWhiteSpace(SrcPath))
            {
                SaveAppSetting("SrcPath", SrcPath);
            }
        }
        private void btnSelDest_Click(object sender, EventArgs e)
        {
            DestPath = FileUtility.OpenFolderDialog(ConfigurationManager.AppSettings["DestPath"]);
            if (!string.IsNullOrWhiteSpace(DestPath))
            {
                SaveAppSetting("DestPath", DestPath);
            }
        }
        private void SaveAppSetting(string key, string value)
        {
            // Open App.Config of executable
            Configuration config =ConfigurationManager.OpenExeConfiguration (ConfigurationUserLevel.None);

            // Add an Application Setting.
            //config.AppSettings.Settings.Add(key, value + " ");
            config.AppSettings.Settings[key].Value = value;

            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");

            //configuration.AppSettings.Settings[key].Value = value;
            //configuration.Save(ConfigurationSaveMode.Full, true);
            //ConfigurationManager.RefreshSection("appSettings");
        }
        private void CopyPackages()
        {
            WriteLog($"開始拷貝更新包........");

            if (!Directory.Exists(TopPackagePath))
                Directory.CreateDirectory(TopPackagePath);

            foreach (string packageName in PackageNameList)
            {
                if (string.IsNullOrWhiteSpace(packageName)) continue;

                WriteLog($"　　Copy 〔{packageName}〕");

                string srcfolder = Directory.GetDirectories(SrcPath, packageName, SearchOption.AllDirectories).FirstOrDefault();

                if (string.IsNullOrWhiteSpace(srcfolder))
                {
                    WriteLog($"Folder〔{packageName}〕 Not Exist;");
                    continue;
                }

                string destPackageDir = Path.Combine(TopPackagePath, packageName);
                Directory.CreateDirectory(destPackageDir);

                FileUtility.CopyAll(srcfolder, destPackageDir);
            }

            WriteLog($"拷貝完成！" + Environment.NewLine);
        }
        private bool CheckFolderName()
        {
            WriteLog($"檢查第一層目錄名稱是否為(DB/MES)........");

            List<string> legalFolders = new List<string>() { "DB", "MES" , "PDF"};

            bool isValid = true;
            foreach (var dir in Directory.GetDirectories(TopPackagePath,"*", SearchOption.TopDirectoryOnly))
            {
                PackageFolders.Add(dir);
                WriteLog($"　　Check 〔{dir}〕");

                var folders = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly);
                foreach(var folder in folders)
                {
                    string folderName = Path.GetFileName(folder).ToUpper();
                    if (!legalFolders.Contains(folderName))
                    { 
                        WriteLog($"　　不合法資料夾 =>" + folder);
                        isValid = false;
                    }

                    if (folderName == "DB")
                        DBFolderPaths.Add(folderName);
                }
            }
            string msg = !isValid ? "有錯誤，請修正～" : "";
            WriteLog($"檢查完成！ {msg}" + Environment.NewLine);

            return isValid;
        }
        private void MergeFolders()
        {
            WriteLog($"開始合併檔案........");

            if (!Directory.Exists(TopMergePath))
                Directory.CreateDirectory(TopMergePath);

            PackageFolders.ForEach(dir => {
                FileUtility.CopyAll(dir, TopMergePath, true);
            });

            WriteLog("合併檔案完成........" + Environment.NewLine);
        }
        private void WriteLog(string msg)
        {
           this.BeginInvoke((Action)(() => {
               txtResult.AppendText(msg);
               txtResult.AppendText(Environment.NewLine);
           }));
        }
        private void EnableForm(bool enable)
        {
            btnMerge.Enabled = enable;
            txtSrcPath.ReadOnly = !enable;
            txtDestPath.ReadOnly = !enable;
            txtResult.ReadOnly = !enable;
        }
    }

    public static class Extend
    {
        public static TextBox AppendText2(this TextBox textbox, string text)
        {
            textbox.AppendText(text);
            return textbox;
        }
    }
}
