using FSHandelsAppen.Api.Services.Interfaces;
using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Api.Services;

public class ProductService : IProductService
{
    // TODO: Injektera IProductRepository via konstruktor

    public Task<IEnumerable<ProductDto>> GetAllAsync() => throw new NotImplementedException();
    public Task<ProductDto?> GetByIdAsync(int id) => throw new NotImplementedException();
    public Task<ProductDto> CreateAsync(CreateProductDto dto) => throw new NotImplementedException();
    public Task<ProductDto?> UpdateAsync(int id, CreateProductDto dto) => throw new NotImplementedException();
    public Task<bool> DeleteAsync(int id) => throw new NotImplementedException();
}
