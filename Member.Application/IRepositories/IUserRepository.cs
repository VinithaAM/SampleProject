using Member.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.IRepositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}
