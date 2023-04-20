using BlogSharp2023.DAL.Model;

namespace BlogSharp2023.DAL;
public interface IBlogPostDao
{
    IEnumerable<BlogPost> Get10NewestBlogPosts();
    IEnumerable<BlogPost> GetAll();
    BlogPost? GetById(int id);
    int Add(BlogPost blogPost);
    bool Update(BlogPost blogPost);
    bool Delete(int id);
}