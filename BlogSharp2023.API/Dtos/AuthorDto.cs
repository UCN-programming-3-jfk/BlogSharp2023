using System.ComponentModel.DataAnnotations;

namespace BlogSharp2023.API.Dtos
{
    public class AuthorDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string BlogTitle { get; set; }
    }
}