namespace ECommerce_Flutter3.Models;

public partial class Cart
{
    public int CartId { get; set; }
    public string UserId { get; set; } = null!;
    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}