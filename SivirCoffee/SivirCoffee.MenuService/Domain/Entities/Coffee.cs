using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.ProductService.Domain.Entities;

public class Coffee
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public Guid CoffeeName { get; set; }
    
    [Required]
    public double Amount { get; set; }
    
    public Guid? CondimentId { get; set; }
    
    public Condiments Condiment { get; set; }
}