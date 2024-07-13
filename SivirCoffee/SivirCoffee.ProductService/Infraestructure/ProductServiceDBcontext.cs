using Microsoft.EntityFrameworkCore;
using SivirCoffee.ProductService.Entities;

namespace SivirCoffee.ProductService.Infraestructure
{
    public class ProductServiceDBcontext : DbContext
    {
        public ProductServiceDBcontext(DbContextOptions<ProductServiceDBcontext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}