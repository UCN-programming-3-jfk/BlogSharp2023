using BlogSharp2023.DAL;
using BlogSharp2023.DAL.Model;
using RestSharp;

namespace BlogSharp2023.APICLIENT
{
    public class AuthorApiClient : IAuthorDao
    {
        RestClient _client;
        public AuthorApiClient(string apiRessourceUrl)
        {
            _client = new RestClient(apiRessourceUrl);
        }
        public int Add(Author author)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Author? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Author? Login(string email, string password)
        {
            var loginRequest = new RestRequest("", Method.Post);
            loginRequest.AddBody(new Login() {Email = email, Password = password });
            return _client.Post<Author?>(loginRequest);
        }

        public bool Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}