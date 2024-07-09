using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.AuthenticationService.Entities
{
    public class User
    {
        [Key]
        private Guid id {  get; set; }

        [Required]
        private string name { get; set; }

        [Required]
        private string password { get; set; }


    }
}
