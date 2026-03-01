using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Client.Services;

public class CartService : ICartService
{
    // TODO: Kundvagn sparas i minne, kan utökas med LocalStorage

    public List<CartItemDto> GetCart() => throw new NotImplementedException();
    public void AddToCart(CartItemDto item) => throw new NotImplementedException();
    public void RemoveFromCart(int productId) => throw new NotImplementedException();
    public void ClearCart() => throw new NotImplementedException();
    public decimal GetTotal() => throw new NotImplementedException();
}
