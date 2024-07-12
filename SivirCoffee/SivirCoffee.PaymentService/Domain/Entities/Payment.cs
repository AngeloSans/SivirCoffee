using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.PaymentService.Entities
{
    public class Payment
    {
        [Key]
        private Guid Id { get; set; }
    }
}
