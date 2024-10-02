namespace Slim.Training.Api.DependencyInjection.Services;

public interface IDummyService
{
    void PrintId();
}

public class DummyService : IDummyService
{
    public void PrintId()
    {
        Console.WriteLine("Service");
    }
}

public class AnotherDummyService : IDummyService
{
    public void PrintId()
    {
        Console.WriteLine("AnotherDummyService");
    }
}

public class FinalDummyService : IDummyService
{
    public void PrintId()
    {
        Console.WriteLine("FinalDummyService");
    }
}