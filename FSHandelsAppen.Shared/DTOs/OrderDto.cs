using System.ComponentModel.DataAnnotations;

namespace FSHandelsAppen.Shared.DTOs;

public class OrderDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Status { get; set; } = string.Empty;
    public List<OrderItemDto> Items { get; set; } = new();
    public decimal TotalAmount { get; set; }
}

public class OrderItemDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
}

public class CreateOrderDto
{
    [Required]
    public List<OrderItemDto> Items { get; set; } = new();
}
