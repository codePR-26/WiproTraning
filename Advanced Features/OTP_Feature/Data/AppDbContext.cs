
using Microsoft.EntityFrameworkCore;
using NestInn.Models;

namespace NestInn.Data
{
 public class AppDbContext:DbContext
 {
  public AppDbContext(DbContextOptions<AppDbContext> options):base(options){} // app DB contexts Clas

  public DbSet<OTPVerification> OTPVerifications {get;set;}
        // database connect.
 }
}
