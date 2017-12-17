using ODTGUI.ApplicationModels.Enums;
using System;
using System.IO;
using System.Text;

namespace ODTGUI.Utils
{
    public class ApplicationLogger: ILogger
    {
        const string LOG_FILE_PATH = "logs.log";
        private LogLevel _logLevel;

        public ApplicationLogger(LogLevel logLevel, bool clearOldLogs = false)
        {
            _logLevel = logLevel;
            if (clearOldLogs)
            {
                File.Delete(LOG_FILE_PATH);
            }
        }

        public void Log(string log, LogLevel level)
        {
            if((int)level <= (int)_logLevel)
            {
                using (var sw = new StreamWriter(LOG_FILE_PATH, true, Encoding.ASCII, 128))
                {
                    sw.WriteLine($"{DateTime.Now}: {log}");
                }
            }
        }
    }
}
