namespace MyApp.Services.Internal;

using MyApp.Interfaces;

class SmsNotificationService : INotificationService
{
    public string Type { get; set; } = "sms";
    public void Send(string user, string message)
    {

        Console.WriteLine($"... sending sms ...");
    }
}

