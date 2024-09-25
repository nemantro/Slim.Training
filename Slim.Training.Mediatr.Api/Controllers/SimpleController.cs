using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Slim.Training.Mediatr.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SimpleController : ControllerBase
{
    private readonly ILogger<SimpleController> _logger;
    private readonly IMediator _mediator;

    public SimpleController(ILogger<SimpleController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet("/ping")]
    public Task<string> Ping() => _mediator.Send(new PingRequest());
    
    [HttpGet("/oneway")]
    public Task OneWay() => _mediator.Send(new OneWayRequest());
    
    [HttpGet("/publish")]
    public Task Publish() => _mediator.Publish(new EventNotification());
}