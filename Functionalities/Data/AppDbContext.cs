
using Microsoft.EntityFrameworkCore;
using NestInn.Models;

namespace NestInn.Data
{
public class AppDbContext : DbContext
{

public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}

public DbSet<User> Users { get; set; }

public DbSet<Property> Properties { get; set; }

}
}
