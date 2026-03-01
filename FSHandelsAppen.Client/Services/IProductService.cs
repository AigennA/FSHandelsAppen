using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Client.Services;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetAllAsync();
    Task<ProductDto?> GetByIdAsync(int id);
}
