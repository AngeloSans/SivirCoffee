using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.PaymentService.Entities
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        
    }
}
