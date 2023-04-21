using BlogSharp2023.DAL;
using BlogSharp2023.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2023.MVC.Controllers;
public class AuthorsController : Controller
{
    IAuthorDao _authorDao;
    public AuthorsController(IAuthorDao authorDao) => _authorDao = authorDao;

    // GET: Authors/Create
    public ActionResult Create() => View();

    // POST: Authors/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Author author)
    {
        try
        {
            if(!ModelState.IsValid) { throw new InvalidDataException(); }
            _authorDao.Add(author);
            return RedirectToAction("Index", "Home");
        }
        catch {return View();}
    }
}
