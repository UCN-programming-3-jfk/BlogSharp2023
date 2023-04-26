using BlogSharp2023.API.Dtos;
using BlogSharp2023.DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2023.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        [HttpPost]
        public ActionResult<Author?> Login(Login login)
        {
            return Ok(new Author());
        }

       

    }
}
