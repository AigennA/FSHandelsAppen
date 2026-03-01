using FSHandelsAppen.Api.Models;
using FSHandelsAppen.Api.Repositories.Interfaces;

namespace FSHandelsAppen.Api.Repositories;

public class ProductRepository : IProductRepository
{
    public Task<IEnumerable<Product>> GetAllAsync() => throw new NotImplementedException();
    public Task<Product?> GetByIdAsync(int id) => throw new NotImplementedException();
    public Task<Product> AddAsync(Product product) => throw new NotImplementedException();
    public Task<Product?> UpdateAsync(int id, Product product) => throw new NotImplementedException();
    public Task<bool> DeleteAsync(int id) => throw new NotImplementedException();
}
