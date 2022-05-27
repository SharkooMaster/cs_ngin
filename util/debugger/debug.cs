using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;

namespace csNgin.util
{
    static class debug
    {
        private static Process p;
        private static StreamReader sr;
        private static StreamWriter sw;
        static debug()
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardError   = true,
                RedirectStandardInput   = true,
                RedirectStandardOutput  = true,
                UseShellExecute         = false
            };

            p  = Process.Start(psi);
            sw = p.StandardInput;
            sr = p.StandardOutput;
        }

        public static void log(string _x)
        {
            sw.WriteLine(_x);
            p.Refresh();
        }
    }
}