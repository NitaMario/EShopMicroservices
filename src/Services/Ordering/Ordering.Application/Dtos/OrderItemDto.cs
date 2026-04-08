namespace Ordering.Application.Dtos;

public record OrderItemDto(Guid OrderId, Guid ProductOd, int Quantity, decimal Price);
