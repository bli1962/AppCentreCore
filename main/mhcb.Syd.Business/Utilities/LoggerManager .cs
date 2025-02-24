using log4net;
using log4net.Config;
using System.Reflection;
using System.Xml;
using System;
using System.IO;

namespace mhcb.Syd.Business.Utilities
{
    //https://blog.hackajob.co/how-to-log-in-asp-net-core-web-apps-using-log4net/
    //public class LoggerManager : ILoggerManager
    //{
    //    private readonly ILog _logger = LogManager.GetLogger(typeof(LoggerManager));

    //    public LoggerManager()
    //    {
    //        try
    //        {
    //            XmlDocument log4netConfig = new XmlDocument();

    //            using (var fs = File.OpenRead("log4net.config"))
    //            {
    //                log4netConfig.Load(fs);

    //                var repo = LogManager.CreateRepository(
    //                            Assembly.GetEntryAssembly(),
    //                            typeof(log4net.Repository.Hierarchy.Hierarchy));

    //                XmlConfigurator.Configure(repo, log4netConfig["log4net"]);

    //                // The first log to be written 
    //                _logger.Info("Log System Initialized");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            _logger.Error("Error", ex);
    //        }
    //    }


    //    public void LogInformation(string message)
    //    {
    //        _logger.Info(message);
    //    }
    //    public void LogDebug(string message)
    //    {
    //        _logger.Debug(message); ;
    //    }
    //    public void LogError(string message)
    //    {
    //        _logger.Error(message);
    //    }
    //    public void LogWarning(string message)
    //    {
    //        _logger.Warn(message);
    //    }
    //    public void LogCritical(string message)
    //    {
    //        _logger.Error(message);
    //    }
    //    public void LogTrace(string message)
    //    {
    //        _logger.Debug(message);
    //    }
    //}
}
