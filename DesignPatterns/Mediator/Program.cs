using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

// Create DI container
var services = new ServiceCollection();

// Register MediatR
services.AddMediatR(cfg => cfg
.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

// Build the service provider
var provider = services.BuildServiceProvider();

// Get an instance of IMediator
var mediator = provider.GetRequiredService<IMediator>();

// Send a test request
var result = await mediator.Send(new Ping());
Console.WriteLine(result);

// Sample request & handler
public class Ping : IRequest<string> { }

public class PingHandler : IRequestHandler<Ping, string>
{
	public Task<string> Handle(Ping request, CancellationToken cancellationToken)
	{
		return Task.FromResult("Pong!");
	}
}
