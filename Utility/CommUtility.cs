using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesFileTool.Utility
{
    public static class CommUtility
    {
        public static string[] SplitbyStr(this string src, string separator = "\r\n", StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries)
        {
            return src.Split(new string[] { separator }, options);
        }

    }
}
