namespace BlogSharp2023.MVC.Controllers
{
    public interface IBlogPostDao
    {
        IEnumerable<BlogPost> Get10NewestBlogPosts();
    }
}