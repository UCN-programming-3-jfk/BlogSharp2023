namespace BlogSharp2023.DAL
{

    //A blogpost class with an id, a creationdate (datetime) a title and a content

    public class BlogPost
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } 
        public int AuthorId { get; set; }


        public BlogPost(int id, DateTime creationDate, string title, string content, int authorId) : this(creationDate, title, content, authorId)
        {
            Id = id;
        }
        public BlogPost(DateTime creationDate, string title, string content, int authorId)
        {
            CreationDate = creationDate;
            Title = title;
            Content = content;
            AuthorId = authorId;
        }
        public BlogPost()
        {
            
        }


    }
}