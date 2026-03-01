using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Api.Services.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetAllAsync();
    Task<ProductDto?> GetByIdAsync(int id);
    Task<ProductDto> CreateAsync(CreateProductDto dto);
    Task<ProductDto?> UpdateAsync(int id, CreateProductDto dto);
    Task<bool> DeleteAsync(int id);
}
