using KancelAPI.Models.Administration;
using Microsoft.EntityFrameworkCore;

namespace KancelAPI.Context
{
    public class KancelContext : DbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public KancelContext(DbContextOptions<KancelContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
