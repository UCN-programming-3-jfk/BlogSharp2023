using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSharp2023.DAL
{
    public class InMemoryBlogPostDao : IBlogPostDao
    {
        private List<BlogPost> _blogPosts = new List<BlogPost>() { };
        public InMemoryBlogPostDao()
        {
            _blogPosts.Add(new BlogPost(1, DateTime.Now, "First Blog Post", "This is the first blog post", 1));
            _blogPosts.Add(new BlogPost(2, DateTime.Now, "Second Blog Post", "This is the second blog post", 1));
            _blogPosts.Add(new BlogPost(3, DateTime.Now, "Third Blog Post", "This is the third blog post", 1));
            _blogPosts.Add(new BlogPost(4, DateTime.Now, "Fourth Blog Post", "This is the fourth blog post", 1));
            _blogPosts.Add(new BlogPost(5, DateTime.Now, "Fifth Blog Post", "This is the fifth blog post", 1));
            _blogPosts.Add(new BlogPost(6, DateTime.Now, "Sixth Blog Post", "This is the sixth blog post", 1));
            _blogPosts.Add(new BlogPost(7, DateTime.Now, "Seventh Blog Post", "This is the seventh blog post", 1));
           
        }

        public int AddBlogPost(BlogPost blogPost)
        {
            _blogPosts.Add(blogPost);
            return 42;
        }

        public IEnumerable<BlogPost> Get10NewestBlogPosts() => _blogPosts.Take(10);

        public IEnumerable<BlogPost> GetAll() => _blogPosts;

        public BlogPost? GetById(int id) => _blogPosts.FirstOrDefault(b => b.Id == id);

        public bool Update(BlogPost blogPost)
        {
            var postToEdit = GetById(blogPost.Id);
            if(postToEdit == null) { return false; }

            postToEdit.Title = blogPost.Title;
            postToEdit.Content = blogPost.Content;
            return true;
        }
    }
}
