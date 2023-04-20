using BlogSharp2023.DAL.Model;

namespace BlogSharp2023.DAL;
public interface IAuthorDao
{
    Author? Login(string email, string password);
    Author? GetById(int id);
    int Add(Author author);
    bool Update(Author author);
    bool Delete(int id);
}
