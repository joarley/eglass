namespace Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.Logging
{
    using NLog;
    using Rajastech.EGlass.Infrastructure.CrossCutting.Logging;
    using System;
    using System.IO;
    using System.Reflection;

    public class NLogLoggerFactory : ILoggerFactory
    {
        static NLogLogger loggerInstance;
        static object loggerInstanceLock = new object();

        public ILogger Create()
        {
            lock (loggerInstanceLock)
                if (loggerInstance == null)
                    loggerInstance = new NLogLogger(LogManager.GetLogger(""));

            return loggerInstance;
        }
    }
}
