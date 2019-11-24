using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliBiliBlockChain.Utils
{
    public class LogUtil
    {
        public enum LogLevel
        {
            Info,
            Warning,
            Error
        }

        public static void Log(string message)
        {
            Log(message, LogLevel.Info);
        }

        public static void Log(string message, LogLevel level)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"[{now}][{level.ToString()}][{message}]");
            MainForm.logBox1.Invoke(
                    new Action(() =>
                    {
                        MainForm.logBox1.Text += $"[{now}][{level.ToString()}][{message}]\r\n";
                    })
                );
        }
    }
}
