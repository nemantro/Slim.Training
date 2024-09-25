using MediatR;

namespace Slim.Training.Mediatr.Api.Controllers;

public class EventNotification : INotification { }

public class EventNotificationHandler1 : INotificationHandler<EventNotification>
{
    public Task Handle(EventNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Handled by Handler 1");
        return Task.CompletedTask;
    }
}

public class EventNotificationHandler2 : INotificationHandler<EventNotification>
{
    public Task Handle(EventNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Handled by Handler 2");
        return Task.CompletedTask;
    }
}