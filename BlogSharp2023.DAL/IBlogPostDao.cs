namespace BlogSharp2023.DAL
{
    public interface IBlogPostDao
    {
        IEnumerable<BlogPost> Get10NewestBlogPosts();
    }
}