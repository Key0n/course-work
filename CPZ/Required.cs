using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CPZ
{
    internal class Required
    {
        internal readonly static string DataFolder = Application.StartupPath + "\\Data\\";
        internal readonly static string Serial = DataFolder + "account.session";
        internal readonly static string Data = DataFolder + "account.data";

        internal static void Deploy()
        {
            try
            {
                if (!Directory.Exists(DataFolder))
                {
                    Directory.CreateDirectory(DataFolder);
                }
            }
            catch { }
        }
    }
}
