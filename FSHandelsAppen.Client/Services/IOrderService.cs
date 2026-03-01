using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Client.Services;

public interface IOrderService
{
    Task<IEnumerable<OrderDto>> GetMyOrdersAsync();
    Task<OrderDto?> GetByIdAsync(int id);
    Task<OrderDto> CreateOrderAsync(CreateOrderDto dto);
}
