namespace ECommerce_Flutter3.Models;

public partial class Order
{
    public int OrderId { get; set; }
    public string UserId { get; set; } = null!;
    public DateTime? OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = null!;
    public string? ShippingAddress { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}