using MediatR;

namespace Slim.Training.Mediatr.Api.Controllers;

public class PingRequest : IRequest<string> { }

public class PingHandler : IRequestHandler<PingRequest, string>
{
    public Task<string> Handle(PingRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult("Pong");
    }
}