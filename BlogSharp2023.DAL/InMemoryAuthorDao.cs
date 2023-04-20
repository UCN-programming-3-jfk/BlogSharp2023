using BlogSharp2023.DAL.Model;

namespace BlogSharp2023.DAL;
public class InMemoryAuthorDao : IAuthorDao
{
    private List<Author> _authors = new List<Author>();
    private int _nextId = 1;

    public InMemoryAuthorDao()
    {
        Add(new Author { Email = "Anna@gmail.com", Password = "1234", BlogTitle = "Anna's Blog" });
        Add(new Author { Email = "Bob@gmail.com", Password = "1234", BlogTitle = "Bob's Blog" });
        Add(new Author { Email = "Claire@gmail.com", Password = "1234", BlogTitle = "Claire's Blog" });
        Add(new Author { Email = "Dennis@gmail.com", Password = "1234", BlogTitle = "Dennis's Blog" });
        Add(new Author { Email = "Erica@gmail.com", Password = "1234", BlogTitle = "Erica's Blog" });
    }

    public int Add(Author author)
    {
        author.Id = GetNextId();
        _authors.Add(author);
        return author.Id;
    }

    private int GetNextId() => _nextId++;

    public bool Delete(int id) => _authors.Remove(GetById(id));

    public Author? GetById(int id) => _authors.FirstOrDefault(a => a.Id == id);

    public Author? Login(string username, string password) => _authors.FirstOrDefault(a => a.Email == username && a.Password == password);

    public bool Update(Author author)
    {
        var authorToEdit = GetById(author.Id);
        if (authorToEdit == null) { return false; }

        authorToEdit.Email = author.Email;
        authorToEdit.Password = author.Password;
        authorToEdit.BlogTitle = author.BlogTitle;
        return true;
    }
}