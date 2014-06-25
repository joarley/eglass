namespace Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.Logging
{
    using NLog;
    using Rajastech.EGlass.Infrastructure.CrossCutting.Logging;
    using System;

    public class NLogLogger : ILogger
    {
        private readonly Logger log;

        public NLogLogger(Logger log)
        {
            this.log = log;
        }

        public void Debug(string message, params object[] args)
        {
            log.Debug(message, args);
        }

        public void Debug(string message, Exception exception, params object[] args)
        {
            message = string.Format(message, args);

            log.Debug(message, exception);
        }

        public void Debug(object item)
        {
            log.Debug(item);
        }

        public void Fatal(string message, params object[] args)
        {
            log.Fatal(message, args);
        }

        public void Fatal(string message, Exception exception, params object[] args)
        {
            message = string.Format(message, args);

            log.Fatal(message, exception);
        }

        public void LogInfo(string message, params object[] args)
        {
            log.Info(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            log.Warn(message, args);
        }

        public void LogError(string message, params object[] args)
        {
            log.Error(message, args);
        }

        public void LogError(string message, Exception exception, params object[] args)
        {
            message = string.Format(message, args);

            log.Error(message, exception);
        }
    }
}
