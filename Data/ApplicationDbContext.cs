using Microsoft.EntityFrameworkCore;
using SKBKonturInternshipProject.Models;

namespace SKBKonturInternshipProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(500);
            modelBuilder.Entity<Product>().Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Product>().Property(p => p.UpdatedAt).HasDefaultValueSql("GETDATE()");
        }
    }
}