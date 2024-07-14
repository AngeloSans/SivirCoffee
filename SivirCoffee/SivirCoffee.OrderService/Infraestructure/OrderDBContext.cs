using Microsoft.EntityFrameworkCore;
using SivirCoffee.OrderService.Domain.Entities;
using SivirCoffee.OrderService.Entities;

namespace SivirCoffee.OrderService.Infraestructure
{
    public class OrderDBContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderDBContext(DbContextOptions<OrderDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            modelBuilder.Entity<Order>().Property(o => o.Status).IsRequired();
        }
    }
}
