using BlogSharp2023.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2023.MVC.Controllers
{
    
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
            return View();
        }

        // GET: BlogPostsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPostsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection )
        {
            try
            {
                //_blogPostDao.AddBlogPost(newPost);
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
            if (blogPost == null) {return NotFound();}
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
            return View();
        }

        // POST: BlogPostsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
