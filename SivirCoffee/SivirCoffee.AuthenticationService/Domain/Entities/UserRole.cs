using SivirCoffee.AuthenticationService.Service;

namespace SivirCoffee.AuthenticationService.Entities;

public class UserRole
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public Guid RoleId { get; set; }
    public Role Role { get; set; }
}