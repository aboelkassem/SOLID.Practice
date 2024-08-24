using System.Text;

namespace DIPDemo.After
{
    public class FileLogger : ILogger
    {
        public void LogEvent(string message, string category)
        {
            string fileName = string.Format(@"c:\test\Log_{0:yyyy-MM-dd}.txt", DateTime.Today);

            var logLines = new StringBuilder();
            logLines.AppendLine("===========");
            logLines.AppendLine(category);
            logLines.AppendLine("===========");
            logLines.AppendLine(DateTime.Now.ToString());
            logLines.AppendLine(message);

            File.AppendAllText(fileName, logLines.ToString());

            Console.WriteLine("File logger");

        }
    }
}
