using SivirCoffee.PaymentService.Entities;

namespace SivirCoffee.PaymentService.Service;

public interface IPaymentService
{
    Task<IEnumerable<Payment>> GetAllPayments();
    Task Payment(Payment payment);
    Task Repayment(Guid id);
}