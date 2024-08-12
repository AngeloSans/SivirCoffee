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
        public DbSet<TypePayment> TypePayments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

            
            modelBuilder.Entity<Payment>()
                .HasKey(p => p.Id); 
            
            modelBuilder.Entity<TypePayment>()
                .HasKey(tp => tp.Id); 
        }
    }
}