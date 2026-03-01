namespace FSHandelsAppen.Api.Models;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Status { get; set; } = "Pending";
    public List<OrderItem> Items { get; set; } = new();
    public decimal TotalAmount { get; set; }
}
