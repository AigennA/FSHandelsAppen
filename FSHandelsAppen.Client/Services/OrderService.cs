using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Client.Services;

public class OrderService : IOrderService
{
    // TODO: Injektera HttpClient via konstruktor

    public Task<IEnumerable<OrderDto>> GetMyOrdersAsync() => throw new NotImplementedException();
    public Task<OrderDto?> GetByIdAsync(int id) => throw new NotImplementedException();
    public Task<OrderDto> CreateOrderAsync(CreateOrderDto dto) => throw new NotImplementedException();
}
