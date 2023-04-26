using BlogSharp2023.API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2023.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        [HttpPost]
        public ActionResult<AuthorDto?> Login(LoginDto loginDto)
        {
            return new AuthorDto();
        }

       

    }
}
