namespace DIPDemo.After
{
    public class LoggingService
    {
        private ILogger _logger;
        public LoggingService(ILogger logger)
        {
            _logger = logger;
        }

        public void LogEvent(string message, string category)
        {
            _logger.LogEvent(message, category);
        }
    }
}
