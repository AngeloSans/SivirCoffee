using SivirCoffee.PaymentService.Entities;

namespace SivirCoffee.PaymentService.Repository
{
    public interface IPaymentRepository
    {
        Task<List<Payment>> GetPaymentMethods();
        Task MakePayment(Payment payment);
        Task CancelPayment(Guid id);

    }
}
