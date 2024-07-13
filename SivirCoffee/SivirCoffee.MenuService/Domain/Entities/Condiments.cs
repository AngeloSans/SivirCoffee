using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.ProductService.Domain.Entities;

public class Condiments
{
    [Key] 
    public Guid Id;

    [Required] 
    public string Condiment;

    [Required] 
    public double additionalPrice;


}