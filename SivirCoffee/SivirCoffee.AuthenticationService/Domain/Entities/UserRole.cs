using System;
using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.AuthenticationService.Entities
{
    public class UserRole
    {
        [Key]
        public Guid Id { get; set; }


        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
