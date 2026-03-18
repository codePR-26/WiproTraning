namespace FoodDeliveryApp.Models
{
    public class Food
    {

        public int Id { get; set; }

        public int CategoryId { get; set; } // Foreign key to Category
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        // Navigation property
        public Category? Category { get; set; } // make it nullable
    }
}
