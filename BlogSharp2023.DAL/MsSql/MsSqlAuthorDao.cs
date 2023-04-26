using BlogSharp2023.DAL.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSharp2023.DAL.MsSql
{
    public class MsSqlAuthorDao : IAuthorDao
    {

        public string ConnectionString { get; private set; }
        private SqlConnection _connection;
        public MsSqlAuthorDao(string connectionString)
        {
            ConnectionString = connectionString;
            _connection = new SqlConnection(connectionString);
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
            
           return  _connection.Query<Author>("SELECT * FROM Author WHERE Email = @Email AND PasswordWithHash= @Password", new { Email = email, Password = password }).FirstOrDefault();
        }

        public bool Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
