using Microsoft.EntityFrameworkCore;
using SivirCoffee.PaymentService.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SivirCoffee.PaymentService.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentDbContext _dbContext;

        public PaymentRepository(PaymentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Payment>> GetPaymentMethods()
        {
            return await _dbContext.Payments.ToListAsync();
        }

        public async Task MakePayment(Payment payment)
        {
            await _dbContext.Payments.AddAsync(payment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task CancelPayment(Guid id)
        {
            var payment = await _dbContext.Payments.FindAsync(id);
            if (payment != null)
            {
                payment.IsCanceled = true; 
                _dbContext.Payments.Update(payment);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Payment not found!");
            }
        }

        public async Task<Payment> GetPayment(Guid id)
        {
            return await _dbContext.Payments.FindAsync(id) ?? throw new Exception("Payment not found!");
        }

        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            return await _dbContext.Payments.ToListAsync();
        }
    }
}