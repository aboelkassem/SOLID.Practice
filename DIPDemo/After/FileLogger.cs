using System.Text;

namespace DIPDemo.After
{
    public class FileLogger : ILogger
    {
        public void LogEvent(string message, string category)
        {
            var logLines = new StringBuilder();
            logLines.AppendLine("===========");
            logLines.AppendLine(category);
            logLines.AppendLine("===========");
            logLines.AppendLine(DateTime.Now.ToString());
            logLines.AppendLine(message);

            Console.WriteLine(logLines.ToString());

            Console.WriteLine("File logger");
        }
    }
}
