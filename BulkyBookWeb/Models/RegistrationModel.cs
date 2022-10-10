

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class RegistrationModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage ="Passwords does not match try again")]
        public string ConfirmPassword { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

    }
}
