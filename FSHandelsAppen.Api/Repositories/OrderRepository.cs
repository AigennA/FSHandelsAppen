using FSHandelsAppen.Api.Models;
using FSHandelsAppen.Api.Repositories.Interfaces;

namespace FSHandelsAppen.Api.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task<IEnumerable<Order>> GetAllAsync() => throw new NotImplementedException();
    public Task<IEnumerable<Order>> GetByUserIdAsync(int userId) => throw new NotImplementedException();
    public Task<Order?> GetByIdAsync(int id) => throw new NotImplementedException();
    public Task<Order> AddAsync(Order order) => throw new NotImplementedException();
    public Task<Order?> UpdateStatusAsync(int id, string status) => throw new NotImplementedException();
}
