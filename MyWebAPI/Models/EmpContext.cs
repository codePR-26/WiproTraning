using Microsoft.EntityFrameworkCore;

namespace MyWebAPI.Models
{
    public class EmpContext: DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options)
        {
        }
        public DbSet<Employees> Employees { get; set; }
         public DbSet<Department> Departments { get; set; }
    }
}
