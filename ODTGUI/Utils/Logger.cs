using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODTGUI.Utils
{
    public class Logger: ILogger
    {
        const string ERROR_LOG_FILE_PATH = "errors.log";

        public Logger(bool clearOldLogs = false)
        {
            if (clearOldLogs)
            {
                File.Delete(ERROR_LOG_FILE_PATH);
            }
        }

        public void Log(string log)
        {
            using (var sw = new StreamWriter(ERROR_LOG_FILE_PATH, true, Encoding.ASCII, 128))
            {
                sw.WriteLine(log);
            }
        }
    }
}
