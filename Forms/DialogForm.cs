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
    public partial class DialogForm : Form
    {
        public string AuthCode => this.textBox1.Text.Trim();
        public Button ConfirmBtn => this.button1;
        public DialogForm()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBox1.Text = "";
        }
    }
}
