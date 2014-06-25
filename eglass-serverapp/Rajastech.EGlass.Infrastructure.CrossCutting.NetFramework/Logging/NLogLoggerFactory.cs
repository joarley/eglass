namespace Rajastech.EGlass.Infrastructure.CrossCutting.NetFramework.Logging
{
    using NLog;
    using Rajastech.EGlass.Infrastructure.CrossCutting.Logging;
    using System;
    using System.IO;
    using System.Reflection;

    public class NLogLoggerFactory : ILoggerFactory
    {
        public ILogger Create(string logName)
        {
            return new NLogLogger(LogManager.GetLogger(logName));
        }
    }
}
