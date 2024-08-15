using SivirCoffee.PaymentService.Entities;

namespace SivirCoffee.PaymentService.Repository
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<TypePayment>> GetPaymentMethods();
        Task MakePayment(Payment payment);
        Task CancelPayment(Guid id);

    }
}
