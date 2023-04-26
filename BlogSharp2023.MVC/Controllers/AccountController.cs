using BlogSharp2023.DAL;
using BlogSharp2023.DAL.Model;
using BlogSharp2023.MVC.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogSharp2023.MVC.Controllers
{
    public class AccountController : Controller
    {
        IAuthorDao _authorDao;
        public AccountController(IAuthorDao authorDao) => _authorDao = authorDao;

        [HttpGet]
        [Route("[Controller]/Login")]
        public IActionResult ShowLoginForm() => View("Login");

        [HttpPost]
        public IActionResult ProcessLoginForm(LoginModel loginInfo, [FromQuery] string returnUrl)
        {
            Author? author = _authorDao.Login(loginInfo.Email, loginInfo.Password);
            if (author != null)
            {
                SignIn(author);
                return Redirect(returnUrl);
            }
            return View("Login");

        }



        private void SignIn(Author author)
        {
            var claims = new List<Claim>
        {
            new Claim("id",author.Id.ToString()),
            new Claim(ClaimTypes.Email, author.Email),
        };
            //Kenni siger - hvorfor? Måske kan dette simplificeres, da det allerede står i Program.CS
            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)).Wait();

            //TempData["Message"] = $"You are logged in as {claimsIdentity.Name}";
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
