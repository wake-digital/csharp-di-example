namespace MyApp.Services.Internal;

using MyApp.Interfaces;

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

