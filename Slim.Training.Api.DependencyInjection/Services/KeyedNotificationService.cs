namespace Slim.Training.Api.DependencyInjection.Services;

public interface IKeyedNotificationService
{
    void Notify(string message);
}

public class SmsKeyedNotificationService : IKeyedNotificationService
{
    public void Notify(string message) => Console.WriteLine($"[SMS] {message}");
}

public class EmailKeyedNotificationService : IKeyedNotificationService
{
    public void Notify(string message) => Console.WriteLine($"[Email] {message}");
}

public class PushKeyedNotificationService : IKeyedNotificationService
{
    public void Notify(string message) => Console.WriteLine($"[Push] {message}");
}

public class AllKeyedNotificationServicesConsumer(IEnumerable<IKeyedNotificationService> services)
{
    public void Notify()
    {
        if(!services.Any())
        {
            Console.WriteLine("No registered services");
        }
        
        foreach (var service in services)
        {
            service.Notify("All keyed services notification");
        }
    }
}

public class KeyedNotificationServicesConsumer([FromKeyedServices("email")] INotificationService service)
{
    public void Notify()
    {
        service.Notify("[SINGLE] Email service notification");
    }
}