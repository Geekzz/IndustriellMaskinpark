using IndustriellMaskinpark.Domain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IndustriellMaskinpark.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure enums to be stored as strings
            modelBuilder.Entity<Device>()
                .Property(d => d.Type)
                .HasConversion<string>();

            modelBuilder.Entity<Device>()
                .Property(d => d.Status)
                .HasConversion<string>();
        }
    }
}
