using NLog;

var Logger = NLog.LogManager.GetCurrentClassLogger();

Console.WriteLine("Hello, World!");
Logger.Trace("Hello world");