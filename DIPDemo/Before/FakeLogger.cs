namespace DIPDemo.Before
{
    public class FakeLogger
    {
        public void LogEvent(string message, string category)
        {
            // Do nothing. Used for testing

            Console.WriteLine("Fake logger");
        }
    }
}
