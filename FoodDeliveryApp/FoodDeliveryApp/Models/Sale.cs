using FoodDeliveryApp.Models;

public class Sale
{
    public int SaleId { get; set; }
    public decimal TotalAmount { get; set; }

    public int UserId { get; set; } // FK
    public ApplicationUser? User { get; set; } // Nullable

    public DateTime Date { get; set; }
    public string Status { get; set; } = "Pending"; // default value
}