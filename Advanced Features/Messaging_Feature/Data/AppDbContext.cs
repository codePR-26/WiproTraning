
using Microsoft.EntityFrameworkCore;
using NestInn.Models;

namespace NestInn.Data
{
 public class AppDbContext:DbContext
 {
        // this is app db context class
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    // this is using for db connection 
        public DbSet<Message> Messages {get;set;}
        
 }
}
