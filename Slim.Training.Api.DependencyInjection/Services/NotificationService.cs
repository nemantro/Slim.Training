namespace Slim.Training.Api.DependencyInjection.Services;

public interface INotificationService
{
    void Notify(string message);
}

public class SmsNotificationService : INotificationService
{
    public void Notify(string message) => Console.WriteLine($"[SMS] {message}");
}

public class EmailNotificationService : INotificationService
{
    public void Notify(string message) => Console.WriteLine($"[Email] {message}");
}

public class PushNotificationService : INotificationService
{
    public void Notify(string message) => Console.WriteLine($"[Push] {message}");
}

public class NotifierAllServices(IEnumerable<INotificationService> services)
{
    public void Notify()
    {
        foreach (var service in services)
        {
            service.Notify("All services notification");
        }
    }
}

public class NotificationServiceConsumer(INotificationService service)
{
    public void Notify()
    {
        service.Notify("[SINGLE] last registred service notification");
    }
}