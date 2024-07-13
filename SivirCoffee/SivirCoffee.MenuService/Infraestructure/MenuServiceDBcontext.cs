using Microsoft.EntityFrameworkCore;
using SivirCoffee.ProductService.Domain.Entities;

namespace SivirCoffee.ProductService.Infrastructure
{
    public class MenuServiceDBcontext : DbContext
    {
        public MenuServiceDBcontext(DbContextOptions<MenuServiceDBcontext> options) : base(options)
        {
        }

        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Condiments> Condiments { get; set; }
        public DbSet<Candy> Candies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}