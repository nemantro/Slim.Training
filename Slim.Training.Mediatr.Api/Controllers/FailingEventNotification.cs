using MediatR;

namespace Slim.Training.Mediatr.Api.Controllers;

public class FailingEventNotification : INotification
{
}

public class FailingEventNotificationFail : INotificationHandler<EventNotification>
{
    public Task Handle(EventNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Handled by Handler 1");
        throw new Exception("Failing Event Notification handling");
    }
}

public class FailingEventNotificationOk : INotificationHandler<EventNotification>
{
    public Task Handle(EventNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Handled by Handler 2");
        return Task.CompletedTask;
    }
}