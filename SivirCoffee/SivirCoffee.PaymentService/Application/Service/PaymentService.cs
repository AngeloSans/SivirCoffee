using SivirCoffee.PaymentService.Entities;
using SivirCoffee.PaymentService.Repository;

namespace SivirCoffee.PaymentService.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public async Task<IEnumerable<TypePayment>> GetAllPayments()
        {
            var payment = await _paymentRepository.GetPaymentMethods();
            
            return payment.Select(p => new TypePayment
            {
                Id = p.Id
            })
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
