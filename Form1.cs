using Microsoft.WindowsAPICodePack.Dialogs;
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

namespace FileManager
{
    public partial class Form1 : Form
    {

        private List<string> PackageList => txtPackage.Text.Trim().Replace("\r\n", ",").Split(',').ToList();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelSrc_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;
                dialog.Multiselect = false;
                dialog.DefaultDirectory = ConfigurationManager.AppSettings["SrcPath"];
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtSrcPath.Text = dialog.FileName;
                    SaveKey("SrcPath", txtSrcPath.Text.Trim());
                }
            }
           

            var rootDirInfo = new DirectoryInfo(txtSrcPath.Text);

            List<string> result = new List<string>();
            WalkDirectoryTree(rootDirInfo, result);

            textBox1.Text = string.Join(Environment.NewLine, result);
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

        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void btnSelDest_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;
                dialog.Multiselect = false;
                dialog.DefaultDirectory = ConfigurationManager.AppSettings["DestPath"];
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtDestPath.Text = dialog.FileName;
                    SaveKey("DestPath", txtDestPath.Text.Trim());
                }
            }
            
        }

        private void SaveKey(string key, string value)
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


    }
}
