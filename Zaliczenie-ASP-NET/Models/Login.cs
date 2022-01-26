using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zaliczenie_ASP_NET.Models
{
    public class Login
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 3)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Email Adress")]
        public string EmailAdress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and password confirmation must match")]
        [DisplayName("Confirm password")]
        public string ConfirmPassword { get; set; }
    }
}
