using Microsoft.EntityFrameworkCore;
using SivirCoffee.PaymentService.Entities;

namespace SivirCoffee.PaymentService.Repository
{
    public class PaymentDbContext : DbContext
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Payment>()
                .HasKey(p => p.Id); 

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .IsRequired(); 

            modelBuilder.Entity<Payment>()
                .Property(p => p.PaymentDate)
                .IsRequired(); 

            modelBuilder.Entity<Payment>()
                .Property(p => p.IsCanceled)
                .IsRequired(); 
        }
    }
}