using Member.Application.IRepositories;
using Member.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        List<User> user = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "john@example.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "jane@example.com" },
            new User { Id = 3, Name = "Alice Johnson", Email = "alice@example.com" },
            new User { Id = 4, Name = "Bob Brown", Email = "bob@example.com" }
            };

           
        public List<User> GetUsers()
        {
            return user;
        }
    }
}
