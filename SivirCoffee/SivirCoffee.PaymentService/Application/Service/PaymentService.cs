using SivirCoffee.PaymentService.Entities;

namespace SivirCoffee.PaymentService.Service
{
    public class PaymentService : IPaymentService
    {
        public Task<IEnumerable<TypePayment>> GetAllPayments()
        {
            
        }

        public Task Payment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public Task Repayment(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
