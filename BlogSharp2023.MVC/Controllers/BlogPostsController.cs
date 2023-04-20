using BlogSharp2023.DAL;
using BlogSharp2023.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2023.MVC.Controllers;
public class BlogPostsController : Controller
{
    IBlogPostDao _blogPostDao;

    public BlogPostsController(IBlogPostDao blogPostDao)
    {
        _blogPostDao = blogPostDao;
    }

    // GET: BlogPostsController
    public ActionResult Index()
    {
        return View(_blogPostDao.GetAll());
    }

    // GET: BlogPostsController/Details/5
    public ActionResult Details(int id)
    {
        var blogPost = _blogPostDao.GetById(id);
        if (blogPost == null) { return NotFound(); }
        return View(blogPost);
    }

    // GET: BlogPostsController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: BlogPostsController/Create
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
        var blogPost = _blogPostDao.GetById(id);
        if (blogPost == null) { return NotFound(); }
        return View(blogPost);
    }

    // POST: BlogPostsController/Edit/5
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

    // GET: BlogPostsController/Delete/5
    public ActionResult Delete(int id)
    {
        var blogPost = _blogPostDao.GetById(id);
        if (blogPost == null) { return NotFound(); }
        return View(blogPost);
    }

    // POST: BlogPostsController/Delete/5
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
