using BlogSharp2023.DAL.Model;

namespace BlogSharp2023.DAL
{
    public class InMemoryBlogPostDao : IBlogPostDao
    {
        private int _nextId = 0;
        private List<BlogPost> _blogPosts = new List<BlogPost>() { };
        public InMemoryBlogPostDao()
        {
            Add(new BlogPost("First Blog Post", "This is the first blog post", 1));
            Add(new BlogPost("Second Blog Post", "This is the second blog post", 2));
            Add(new BlogPost("Third Blog Post", "This is the third blog post", 2));
            Add(new BlogPost("Fourth Blog Post", "This is the fourth blog post", 3));
            Add(new BlogPost("Fifth Blog Post", "This is the fifth blog post", 3));
            Add(new BlogPost("Sixth Blog Post", "This is the sixth blog post", 3));
            Add(new BlogPost("Seventh Blog Post", "This is the seventh blog post", 4));
        }
        public int Add(BlogPost blogPost)
        {
            blogPost.Id = GetNextId();
            _blogPosts.Add(blogPost);
            return blogPost.Id;
        }
        public bool Delete(int id)
        {
            return _blogPosts.RemoveAll(post => post.Id == id) > 0;
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
        private int GetNextId() => _nextId++;
    }
}
