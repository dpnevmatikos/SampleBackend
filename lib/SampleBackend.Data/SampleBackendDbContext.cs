using Microsoft.EntityFrameworkCore;

using SampleBackend.Model;

namespace SampleBackend.Data
{
    public class SampleBackendDbContext : DbContext
    {
        public SampleBackendDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .ToTable("Customer");
        }
    }
}