using FoodDeliveryApp.Models;

public class Cart
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public int CustomerId { get; set; }

    public int Qty { get; set; }
    public decimal Price { get; set; }
    public decimal TotalAmount { get; set; }

    // Navigation properties
    public Food? Food { get; set; }       // ⚡ make nullable
    public ApplicationUser? Customer { get; set; } // ⚡ make nullable
}