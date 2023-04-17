namespace BlogSharp2023.DAL
{
    public interface IBlogPostDao
    {
        IEnumerable<BlogPost> Get10NewestBlogPosts();
        int AddBlogPost(BlogPost blogPost);
        IEnumerable<BlogPost> GetAll();

        BlogPost? GetById(int id);
        bool Update(BlogPost blogPost);

    }
}