using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Api.Services.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<OrderDto>> GetAllAsync();
    Task<IEnumerable<OrderDto>> GetByUserIdAsync(int userId);
    Task<OrderDto?> GetByIdAsync(int id);
    Task<OrderDto> CreateAsync(int userId, CreateOrderDto dto);
    Task<OrderDto?> UpdateStatusAsync(int id, string status);
}
