using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesFileTool.Utility
{
    public class FormBase: Form
    {
        public void Invoke(Action action)
        {
            this.BeginInvoke(new Action(action));
        }
    }
}
