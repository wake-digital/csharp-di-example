using MyApp.DI;
using MyApp.Services;
using Microsoft.Extensions.DependencyInjection;

DI.Configure();

var notifier = DI.ServiceProvider.GetRequiredService<Notifier>();

notifier.NotifyUser("user00000001", "Hello user!");
