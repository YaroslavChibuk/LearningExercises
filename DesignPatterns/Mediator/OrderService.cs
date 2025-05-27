using MediatR;

public class OrderService
{
	private readonly IMediator _mediator;

	public OrderService(IMediator mediator)
	{
		_mediator = mediator;
	}

	public async Task CreateOrder()
	{
		var command = new CreateOrderCommand
		{
			ProductName = "Laptop",
			Quantity = 1
		};

		var result = await _mediator.Send(command);
		Console.WriteLine(result);
	}
}
