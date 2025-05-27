using MediatR;

public class CreateOrderCommand : IRequest<string>
{
	public string ProductName { get; set; }
	public int Quantity { get; set; }
}
