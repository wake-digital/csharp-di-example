namespace MyApp.Interfaces;

interface INotificationService
{
    string Type { get; set; }
    void Send(string user, string message);
}

