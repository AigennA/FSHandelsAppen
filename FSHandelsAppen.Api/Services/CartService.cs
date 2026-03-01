using FSHandelsAppen.Api.Services.Interfaces;
using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Api.Services;

public class CartService : ICartService
{
    // TODO: Injektera ICartRepository via konstruktor

    public Task<IEnumerable<CartItemDto>> GetCartAsync(int userId) => throw new NotImplementedException();
    public Task AddToCartAsync(int userId, AddToCartDto dto) => throw new NotImplementedException();
    public Task RemoveFromCartAsync(int userId, int productId) => throw new NotImplementedException();
    public Task ClearCartAsync(int userId) => throw new NotImplementedException();
}
