using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CollegeManagementSystem.Models.Admin> Admins { get; set; }
        public DbSet<CollegeManagementSystem.Models.Professor> Professors { get; set; }
        public DbSet<CollegeManagementSystem.Models.Student> Students { get; set; }
        public DbSet<CollegeManagementSystem.Models.Dept> Depts { get; set; }
        public DbSet<CollegeManagementSystem.Models.Parent> Parents { get; set; }
    }
}
