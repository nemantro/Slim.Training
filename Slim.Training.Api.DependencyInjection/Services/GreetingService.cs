namespace Slim.Training.Api.DependencyInjection.Services;

public interface IService
{
    void PrintId();
}

public abstract class Service() : IService
{
    public void PrintId()
    {
        Console.WriteLine($">> Service {GetType()} with Id {Id} created");
    }

    private Guid Id { get;} = Guid.NewGuid();
}

public interface ITransientGreetingService : IService;
public interface IScopedGreetingService : IService;
public interface ISingletonGreetingService : IService;

public class TransientGreetingService : Service, ITransientGreetingService;
public class ScopedGreetingService : Service, IScopedGreetingService;
public class SingletonGreetingService : Service, ISingletonGreetingService;

public class ServiceWrapper(ITransientGreetingService transientGreetingService, IScopedGreetingService scopedGreetingService, ISingletonGreetingService singletonGreetingService)
{
    public void Print()
    {
        transientGreetingService.PrintId();
        scopedGreetingService.PrintId();
        singletonGreetingService.PrintId();
    }
}