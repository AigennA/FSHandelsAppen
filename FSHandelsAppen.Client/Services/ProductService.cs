using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Client.Services;

public class ProductService : IProductService
{
    // TODO: Injektera HttpClient via konstruktor

    public Task<IEnumerable<ProductDto>> GetAllAsync() => throw new NotImplementedException();
    public Task<ProductDto?> GetByIdAsync(int id) => throw new NotImplementedException();
}
