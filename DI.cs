namespace MyApp.DI;

using Microsoft.Extensions.DependencyInjection;
using MyApp.Interfaces;
using MyApp.Services;
using MyApp.Services.Internal;

public static class DI
{
    public static ServiceProvider ServiceProvider { get; private set; }

    public static void Configure()
    {
        var services = new ServiceCollection();

        services.AddSingleton<INotificationService, EmailNotificationService>();
        services.AddSingleton<INotificationService, SmsNotificationService>();
        services.AddSingleton<ILogger, ConsoleLogger>();
        services.AddSingleton<Notifier>();

        ServiceProvider = services.BuildServiceProvider();
    }
}

