using FSHandelsAppen.Api.Services.Interfaces;
using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Api.Services;

public class OrderService : IOrderService
{
    // TODO: Injektera IOrderRepository via konstruktor

    public Task<IEnumerable<OrderDto>> GetAllAsync() => throw new NotImplementedException();
    public Task<IEnumerable<OrderDto>> GetByUserIdAsync(int userId) => throw new NotImplementedException();
    public Task<OrderDto?> GetByIdAsync(int id) => throw new NotImplementedException();
    public Task<OrderDto> CreateAsync(int userId, CreateOrderDto dto) => throw new NotImplementedException();
    public Task<OrderDto?> UpdateStatusAsync(int id, string status) => throw new NotImplementedException();
}
