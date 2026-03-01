using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Client.Services;

public interface ICartService
{
    List<CartItemDto> GetCart();
    void AddToCart(CartItemDto item);
    void RemoveFromCart(int productId);
    void ClearCart();
    decimal GetTotal();
}
