using Member.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.IServices
{
    public interface IUserService
    {
         List<User> GetUsers();
    }
}
