using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.ProductService.Domain.Entities;

public class Candy
{
    [Key] 
    public Guid Id;
    
    [Required]
    public string candyName { get; set; }
    
    [Required]
    public double amount { get; set; }
    
}