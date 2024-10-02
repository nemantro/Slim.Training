using Microsoft.AspNetCore.Mvc;
using Slim.Training.Api.DependencyInjection.Services;

namespace Slim.Training.Api.DependencyInjection.Controllers;

[ApiController]
[Route("[controller]")]
public class SimpleController : ControllerBase
{
    [HttpGet("/hello")]
    public void Get(
        ITransientGreetingService transientGreetingService,
        IScopedGreetingService scopedGreetingService,
        ISingletonGreetingService singletonGreetingService,
        ServiceWrapper serviceWrapper
    )
    {
        Console.WriteLine("Print resolved services from controller");
        transientGreetingService.PrintId();
        scopedGreetingService.PrintId();
        singletonGreetingService.PrintId();
        
        Console.WriteLine("Print resolved services from wrapper");
        serviceWrapper.Print();
    }
    
    [HttpGet("/keyed")]
    public void TestKeyedServiced(
        NotificationServiceConsumer notificationServiceConsumer,
        NotifierAllServices notifierAllServices,
        KeyedNotificationServicesConsumer keyedNotificationServicesConsumer,
        AllKeyedNotificationServicesConsumer allKeyedNotificationServicesConsumer
    )
    {
        Console.WriteLine("Print without keyed services");
        notificationServiceConsumer.Notify();
        notifierAllServices.Notify();
        
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Print with keyed services");
        keyedNotificationServicesConsumer.Notify();
        allKeyedNotificationServicesConsumer.Notify();
    }
    
    [HttpGet("/overriding")]
    public void TestMultipleAdd(IDummyService dummyService)
    {
        dummyService.PrintId();
    }
}