using SivirCoffee.PaymentService.Entities;

namespace SivirCoffee.PaymentService.Repository;

public class PaymentRepository : IPaymentRepository
{
    public Task<IEnumerable<TypePayment>> GetPaymentMethods()
    {
        throw new NotImplementedException();
    }

    public Task MakePayment(Payment payment)
    {
        throw new NotImplementedException();
    }

    public Task CancelPayment(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task getPayment(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Payment>> getAllPayment()
    {
        throw new NotImplementedException();
    }
}