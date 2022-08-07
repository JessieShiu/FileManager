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

namespace MesFileTool
{
    public partial class Form1 : Form
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

        private UpdateForm UpdateForm;
        private DialogForm DialogForm;

        public Form1()
        {
            InitializeComponent();

            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.BackColor = Color.Transparent;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnOpen, "進入神秘區");

            
            DialogForm = new DialogForm();
            DialogForm.FormClosed += (sender, e) => { };
            DialogForm.ConfirmBtn.Click += (sender, e) =>
            {
                IsAuth = DialogForm.AuthCode == "admin@123";
                if (IsAuth)
                {
                    this.Hide();
                    DialogForm.Hide();
                    ShowUpdateForm();
                }
                else
                {
                    DialogForm.Close();
                    MessageBox.Show("授權碼錯誤");
                }
            };
        }

        private void ShowUpdateForm()
        {
            UpdateForm = new UpdateForm();
            UpdateForm.FormClosed += (s, e1) => { this.Show(); };
            UpdateForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SrcPath = ConfigurationManager.AppSettings["SrcPath"];
            txtPackage.Text = @"
20220106_0001
20220107_0014
20220725_0006
";
            //txtSrcPath.Text = @"C:\Users\user\OneDrive\桌面\測試資料夾\2022";
            //txtDestPath.Text = @"C:\Users\user\OneDrive\桌面\測試資料夾\20220725_0006盤點包";
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
                    CopyPackages();
                    if (CheckFolderName())
                    {
                        MergeFolders();
                        MessageBox.Show("盤點包產生完成!");
                    }
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
            SrcPath = OpenFolderDialog(SrcPath);
            if (!string.IsNullOrWhiteSpace(SrcPath))
            {
                SaveAppSetting("SrcPath", SrcPath);
            }
        }
        private void btnSelDest_Click(object sender, EventArgs e)
        {
            DestPath = OpenFolderDialog(ConfigurationManager.AppSettings["DestPath"]);
            if (!string.IsNullOrWhiteSpace(DestPath))
            {
                SaveAppSetting("DestPath", DestPath);
            }
        }

        private void GetAllFilesAndFolders(string rootFolder)
        {
            var rootDirInfo = new DirectoryInfo(rootFolder);
            List<string> result = new List<string>();
            WalkDirectoryTree(rootDirInfo, result);
        }

        private void WalkDirectoryTree(DirectoryInfo root, List<string> result)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    Console.WriteLine(fi.FullName);

                    //取得版號
                    var versionInfo = FileVersionInfo.GetVersionInfo(fi.FullName);
                    string version = versionInfo.FileVersion;

                    result.Add($"{fi.FullName} (Ver. {version})");
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTree(dirInfo, result);
                }
            }
        }

        private void CopyAll(string sourcePath, string targetPath, bool rename = false)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string filePath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                string newPath = filePath.Replace(sourcePath, targetPath);
                File.Copy(filePath, newPath, true);
                
                //重新命名DB裡面的檔案(一般不需要)
                var parentFolder = Directory.GetParent(filePath);
                if (rename && parentFolder.Name.ToUpper() == "DB")
                {
                    var grandDirName = Directory.GetParent(parentFolder.FullName).Name;

                    string newName = $"{grandDirName}_{Path.GetFileName(newPath)}";
                    File.Move(newPath, newPath.Replace(Path.GetFileName(newPath),newName));
                }
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


        private string OpenFolderDialog(string defaultFolder)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = defaultFolder;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return fbd.SelectedPath;
                }
            }
            return "";
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

                CopyAll(srcfolder, destPackageDir);
            }

            WriteLog($"拷貝完成！" + Environment.NewLine);
        }

        private bool CheckFolderName()
        {
            WriteLog($"檢查第一層目錄名稱是否為(DB/MES)........");

            List<string> legalFolders = new List<string>() { "DB", "MES" };

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
                CopyAll(dir, TopMergePath, true);
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
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (IsAuth)
            {
                this.Hide();
                ShowUpdateForm();
            }
            else
            {
                DialogForm.Clear();
                DialogForm.ShowDialog();
            }
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
