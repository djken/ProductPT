using Microsoft.EntityFrameworkCore;
using ProduitsPT.Models;

namespace ProduitsPT.Data
{
    public class ProduitsDBontext : DbContext
    {
        public ProduitsDBontext(DbContextOptions<ProduitsDBontext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Other configurations ...

            //modelBuilder.Entity<Product>()
            //    .Property(p => p.Price)
            //    .HasColumnType("decimal(18, 2)");

            // If you prefer the HasPrecision method (for EF Core 5+)
            //modelBuilder.Entity<Product>()
            //    .Property(p => p.Price)
            //    .HasPrecision(18, 2);

            //base.OnModelCreating(modelBuilder);
        }


    }
}
