using System.ComponentModel.DataAnnotations;

namespace BlogSharp2023.MVC.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"[^\s]+", ErrorMessage = "No spaces in password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}