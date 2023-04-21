using System.ComponentModel.DataAnnotations;

namespace BlogSharp2023.DAL.Model;
public class Author
{
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [RegularExpression(@"[^\s]+", ErrorMessage = "No spaces in password")]
    public string Password { get; set; }
    
    [Required]
    [StringLength(50)]
    public string BlogTitle { get; set; }
}
