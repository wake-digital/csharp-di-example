namespace MyApp.Services.Internal;

using MyApp.Interfaces;

class EmailNotificationService : INotificationService
{
    public string Type { get; set; } = "email";
    public void Send(string user, string message)
    {
        Console.WriteLine($"... sending email ...");
    }
}

