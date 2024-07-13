using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.AuthenticationService.Entities;

public class Role
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }
}