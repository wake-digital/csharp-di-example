namespace MyApp.Services;

using MyApp.Interfaces;

class Notifier
{
    private readonly IEnumerable<INotificationService> _notifiers;
    private readonly IEnumerable<ILogger> _loggers;

    public Notifier(IEnumerable<INotificationService> notifiers, IEnumerable<ILogger> loggers)
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

