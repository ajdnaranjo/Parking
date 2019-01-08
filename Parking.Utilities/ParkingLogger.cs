using Easy.Logger;
using Easy.Logger.Interfaces;
using System;
using System.Configuration;

namespace Parking.Utilities
{
    public class ParkingLogger
    {
        private static readonly IEasyLogger Logger;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        static ParkingLogger()
        {            
            string logSource = "RPMUnknownSource";
            ILogService logService = Log4NetService.Instance;

            try
            {
                logSource = ConfigurationManager.AppSettings["LoggingSourceName"];
            }
            catch { throw; }

            Logger = logService.GetLogger(logSource);
        }

        public static void Debug(string message, Exception ex)
        {
            Logger.Debug(message, ex);
        }

        public static void Error(string message, Exception ex)
        {
            Logger.Error(message, ex);
        }

        public static void Fatal(string message, Exception ex)
        {
            Logger.Fatal(message, ex);
        }

        public static void Information(string message)
        {
            Logger.Info(message);
        }

        public static void Warning(string message)
        {
            Logger.Warn(message);
        }
    }
}
