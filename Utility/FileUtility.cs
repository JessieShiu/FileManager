using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesFileTool.Utility
{
    public class FileUtility
    {
        public static string OpenFolderDialog(string defaultFolder = "")
        {
            //using (var fbd = new FolderBrowserDialog())
            //{
            //    fbd.SelectedPath = defaultFolder;
            //    DialogResult result = fbd.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {
            //        return fbd.SelectedPath;
            //    }
            //}

            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = defaultFolder,
                IsFolderPicker = true,
                Multiselect = false,
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }

            return "";
        }

        public void GetAllFilesAndFolders(string rootFolder)
        {
            var rootDirInfo = new DirectoryInfo(rootFolder);
            List<string> result = new List<string>();
            WalkDirectoryTree(rootDirInfo, result);
        }

        public static void WalkDirectoryTree(DirectoryInfo root, List<string> result)
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

        public static void CopyAll(string sourcePath, string targetPath, bool rename = false)
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
                    File.Move(newPath, newPath.Replace(Path.GetFileName(newPath), newName));
                }
            }
        }
    }
}
