using MesFileTool.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesFileTool
{
    public partial class DBBackupForm : Form
    {
        private List<string> BakList => txtBakList.Text.SplitbyStr().ToList();

        public DBBackupForm()
        {
            InitializeComponent();
        }

        private void txtBakPath_MouseClick(object sender, MouseEventArgs e)
        {
            string folder = FileUtility.OpenFolderDialog();
            if (!string.IsNullOrWhiteSpace(folder))
            {
                txtBakPath.Text = folder;
            }
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string bakPath = txtBakPath.Text.Trim();
            if (string.IsNullOrWhiteSpace(bakPath))
            {
                MessageBox.Show("請輸入備份路徑!");
                return;
            }

            Task.Factory.StartNew(() =>
            {


            //this.Invoke(() => { txtMsg.AppendText("執行完畢"); });
                MessageBox.Show("執行完畢!");
            });
        }
    }
}
