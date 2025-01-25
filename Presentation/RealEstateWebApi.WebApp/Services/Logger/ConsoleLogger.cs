namespace RealEstateWebApi.WebApp.Services.Logger
{
    public class ConsoleLogger : ILoggerService
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}