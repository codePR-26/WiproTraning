using Microsoft.EntityFrameworkCore;
using FoodDeliveryApp.Models;


namespace FoodDeliveryApp.Data

{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ProductsSold> ProductsSold { get; set; }
    


    }
}
