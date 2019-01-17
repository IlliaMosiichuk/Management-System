using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User Find(string username, string password);
    }
}
