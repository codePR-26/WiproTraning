namespace FoodDeliveryApp.Models;

public class ProductsSold
{
    public int Id { get; set; }   //  Primary Key (Added)

    public int ProductId { get; set; } // Foreign key to Food

    public int SaleId { get; set; } // Foreign key to Sale  

    public int Qty { get; set; }

    public decimal TotalProductAmount { get; set; } // Total amount for this product (Price * Qty)

    public string Status { get; set; } // e.g., "Pending", "Completed", "Cancelled"

    // Navigation
    public Food Food { get; set; }
    public Sale Sale { get; set; }
}