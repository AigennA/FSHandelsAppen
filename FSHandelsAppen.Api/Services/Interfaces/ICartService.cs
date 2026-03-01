using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Api.Services.Interfaces;

public interface ICartService
{
    Task<IEnumerable<CartItemDto>> GetCartAsync(int userId);
    Task AddToCartAsync(int userId, AddToCartDto dto);
    Task RemoveFromCartAsync(int userId, int productId);
    Task ClearCartAsync(int userId);
}
