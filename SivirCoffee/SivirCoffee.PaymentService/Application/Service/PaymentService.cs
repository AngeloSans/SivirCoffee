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
        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            return await _paymentRepository.GetPaymentMethods();
            
        }

        public async Task Payment(Payment payment)
        {
            await _paymentRepository.MakePayment(payment);
        }

        public async Task Repayment(Guid id)
        {
            await _paymentRepository.CancelPayment(id);
        }
    }
}
