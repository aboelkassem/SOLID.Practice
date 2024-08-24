using System.Diagnostics;

namespace DIPDemo.Before
{
    public class EventLogLogger : ILogger
    {
        public void LogEvent(string message, string category)
        {
            var source = "My App";
            var log = "Application";

            //if (!EventLog.SourceExists(source))
            //    EventLog.CreateEventSource(source, log);

            using (var eventLog = new EventLog(log))
            {
                eventLog.Source = source;
                eventLog.WriteEntry(message, EventLogEntryType.Information, 101, 1);
            }

            Console.WriteLine("Event Log logger");
        }
    }
}
