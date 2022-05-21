using log4net;
using Serilog;
using NLog;
using System;
using System.Reflection;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {


            // Serilog
            //Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            //Log.Information("Serilog");

            // Nlog
            //var Nlog = NLog.LogManager.GetCurrentClassLogger();
            //Nlog.Info("NIhad");
            //Nlog.Log(LogLevel.Info, "Info");
            //Nlog.Log(LogLevel.Debug, "Debug");
            //Nlog.Log(LogLevel.Warn, "Warn");
            //Nlog.Log(LogLevel.Trace, "Trace");


            // log4net
            //log4net.Config.BasicConfigurator.Configure();
            //ILog log = log4net.LogManager.GetLogger(typeof(Program));
            //log.Info("Info ");
            //log.Fatal("Fatal");
            //log.Warn("Warning");
        }

    }
    
}
