using MediatR;

namespace Slim.Training.Mediatr.Api.Controllers;

public class OneWayRequest : IRequest;

public class OneWayHandler : IRequestHandler<OneWayRequest>
{
    public Task Handle(OneWayRequest request, CancellationToken cancellationToken)
    {
        Console.WriteLine("One way request handled");
        return Task.CompletedTask;
    }
}