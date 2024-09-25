using MediatR;

namespace Slim.Training.Mediatr.Api;

public class MyCustomPublisher : INotificationPublisher
{
    public Task Publish(IEnumerable<NotificationHandlerExecutor> handlerExecutors, INotification notification, CancellationToken cancellationToken)
    {
        var tasks = handlerExecutors
            .Select(handler => handler.HandlerCallback(notification, cancellationToken))
            .ToArray();

        return Task.WhenAll(tasks);
    }
}