using BlogSharp2023.DAL;
using BlogSharp2023.DAL.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2023.MVC.Controllers;
public class BlogPostsController : Controller
{
    IBlogPostDao _blogPostDao;

    public BlogPostsController(IBlogPostDao blogPostDao)
    {
        _blogPostDao = blogPostDao;
    }

    // GET: BlogPosts
    public ActionResult Index() => View(_blogPostDao.GetAll());

    // GET: BlogPosts/Details/5
    public ActionResult Details(int id)
    {
        //does this code look like edit and delete? 😉
        return LoadAndShow(id);
    }

    private ActionResult LoadAndShow(int id)
    {
        var blogPost = _blogPostDao.GetById(id);
        if (blogPost == null) { return NotFound(); }
        return View(blogPost);
    }

    // GET: BlogPosts/Create

    [Authorize]
    public ActionResult Create() => View();

    // POST: BlogPosts/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(BlogPost newBlogPost)
    {
        try
        {
            _blogPostDao.Add(newBlogPost);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: BlogPosts/Edit/5
    public ActionResult Edit(int id)
    {
        return LoadAndShow(id);
    }

    // POST: BlogPosts/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, BlogPost blogPost)
    {
        try
        {
            if (!_blogPostDao.Update(blogPost)) { return NotFound(); }
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: BlogPosts/Delete/5
    [Authorize]
    public ActionResult Delete(int id)
    {
         return LoadAndShow(id);
    }
    [Authorize]
    // POST: BlogPosts/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            if (!_blogPostDao.Delete(id))
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
