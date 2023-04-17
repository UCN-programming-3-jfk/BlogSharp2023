using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSharp2023.DAL
{
    public class InMemoryBlogPostDao : IBlogPostDao
    {
        private List<BlogPost> _blogPosts = new List<BlogPost>();
        public InMemoryBlogPostDao()
        {
            _blogPosts.Add(new BlogPost(1, DateTime.Now, "First Blog Post", "This is the first blog post", 1));
            _blogPosts.Add(new BlogPost(2, DateTime.Now, "Second Blog Post", "This is the second blog post", 1));
            _blogPosts.Add(new BlogPost(3, DateTime.Now, "Third Blog Post", "This is the third blog post", 1));
            _blogPosts.Add(new BlogPost(4, DateTime.Now, "Fourth Blog Post", "This is the fourth blog post", 1));
            _blogPosts.Add(new BlogPost(5, DateTime.Now, "Fifth Blog Post", "This is the fifth blog post", 1));
            _blogPosts.Add(new BlogPost(6, DateTime.Now, "Sixth Blog Post", "This is the sixth blog post", 1));
            _blogPosts.Add(new BlogPost(7, DateTime.Now, "Seventh Blog Post", "This is the seventh blog post", 1));
            _blogPosts.Add(new BlogPost(8, DateTime.Now, "Eighth Blog Post", "This is the eighth blog post", 1));
            _blogPosts.Add(new BlogPost(9, DateTime.Now, "Ninth Blog Post", "This is the ninth blog post", 1));
            _blogPosts.Add(new BlogPost(10, DateTime.Now, "Tenth Blog Post", "This is the tenth blog post", 1));
            _blogPosts.Add(new BlogPost(11, DateTime.Now, "Eleventh Blog Post", "This is the eleventh blog post", 1));
            _blogPosts.Add(new BlogPost(12, DateTime.Now, "Twelfth Blog Post", "This is the twelfth blog post", 1));
            _blogPosts.Add(new BlogPost(13, DateTime.Now, "Thirteenth Blog Post", "This is the thirteenth blog post", 1));
            _blogPosts.Add(new BlogPost(14, DateTime.Now, "Fourteenth Blog Post", "This is the fourteenth blog post", 1));
            _blogPosts.Add(new BlogPost(15, DateTime.Now, "Fifteenth Blog Post", "This is the fifteenth blog post", 1));
        }
        public IEnumerable<BlogPost> Get10NewestBlogPosts() => _blogPosts;
    }
}
