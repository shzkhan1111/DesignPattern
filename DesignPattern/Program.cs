using DesignPattern.DesignPattern;
using Models;
using Models.Adapter;
using Models.builder;
using Models.ChainOfResposibility;
using Models.CompositeDesignPattern;
using Models.DecoratorDesignPatterb;
using Models.Enums;
using Models.Facade;
using Models.FlyWeight;
using Models.PrototypeDesignPattern;
using Models.Proxy;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;



Logger consoleLogger = new ConsoleLogger(LogLevelEnum.Debug);
Logger fileLogger = new FileLogger(LogLevelEnum.Warning);
Logger emailLogger = new EmailLogger(LogLevelEnum.Error);



consoleLogger.SetNextLogger(fileLogger);
fileLogger.SetNextLogger(emailLogger);

Console.WriteLine("Logging messages:");
//chain repeated for each cvall
consoleLogger.LogMessage(LogLevelEnum.Debug, "This is a debug message.");
consoleLogger.LogMessage(LogLevelEnum.Info, "This is an info message.");
consoleLogger.LogMessage(LogLevelEnum.Warning, "This is a warning message.");
consoleLogger.LogMessage(LogLevelEnum.Error, "This is an error message.");
