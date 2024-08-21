using SivirCoffee.PaymentService.Entities;

namespace SivirCoffee.PaymentService.Repository
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<Payment>> GetPaymentMethods();
        Task MakePayment(Payment payment);
        Task CancelPayment(Guid id);

    }
}
