using ODTGUI.ApplicationModels.Enums;

namespace ODTGUI.Utils
{
    public interface ILogger
    {
        void Log(string log, LogLevel level);
    }
}
