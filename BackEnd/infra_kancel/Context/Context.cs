using domain_kancel.Models.Administration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infra_kancel.Context
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
