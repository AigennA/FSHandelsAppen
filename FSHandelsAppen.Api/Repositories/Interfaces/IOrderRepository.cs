using FSHandelsAppen.Api.Models;

namespace FSHandelsAppen.Api.Repositories.Interfaces;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllAsync();
    Task<IEnumerable<Order>> GetByUserIdAsync(int userId);
    Task<Order?> GetByIdAsync(int id);
    Task<Order> AddAsync(Order order);
    Task<Order?> UpdateStatusAsync(int id, string status);
}
