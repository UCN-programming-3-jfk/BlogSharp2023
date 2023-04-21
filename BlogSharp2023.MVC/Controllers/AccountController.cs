using BlogSharp2023.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2023.MVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("[Controller]/Login")]
        public IActionResult ShowLoginForm()
        {
            return View("Login");
        }


        [HttpPost]
        public IActionResult ProcessLoginForm(LoginModel loginInfo)
        {
            return View();
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
