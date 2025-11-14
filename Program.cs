// IMPLEMENTATION
var smsService = new SmsNotificationService();
var emailService = new EmailNotificationService();
var consoleLogger = new ConsoleLogger();
var notifier = new Notifier(notifiers: [smsService, emailService], loggers: [consoleLogger]);
notifier.NotifyUser("user00000001", "Hello user!");

// INTERFACES
interface INotificationService
{
    string Type { get; set; }
    void Send(string user, string message);
}

interface ILogger
{
    void Log(string message);
}


// BASE CLASSES
class EmailNotificationService : INotificationService
{
    public string Type { get; set; } = "email";
    public void Send(string user, string message)
    {
        Console.WriteLine($"... sending email ...");
    }
}

class SmsNotificationService : INotificationService
{
    public string Type { get; set; } = "sms";
    public void Send(string user, string message)
    {

        Console.WriteLine($"... sending sms ...");
    }
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

// DI CLASSES
class Notifier
{
    private readonly INotificationService[] _notifiers;
    private readonly ILogger[] _loggers;

    public Notifier(INotificationService[] notifiers, ILogger[] loggers)
    {
        _notifiers = notifiers;
        _loggers = loggers;
    }

    public void NotifyUser(string user, string message)
    {
        foreach (var notifier in _notifiers)
        {
            notifier.Send(user, message);
            foreach (var logger in _loggers)
            {
                logger.Log($"Sent message to user: {user} with notifier method: {notifier.Type}\nMessage content: {message}");
            }
        }
    }
}

