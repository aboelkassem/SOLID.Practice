Console.WriteLine("BEFORE");
var b_logSvc = new DIPDemo.Before.LoggingService();
b_logSvc.LogEvent("FILE", "Runing the BEFORE service", "Event");
Console.WriteLine();

Console.WriteLine("AFTER");
var fileLogger = new DIPDemo.After.FileLogger();
var a_logSvc = new DIPDemo.After.LoggingService(fileLogger);
a_logSvc.LogEvent("This is an event", "Event");

Console.WriteLine();
Console.WriteLine("Done");

Console.ReadLine();