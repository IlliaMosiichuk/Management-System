using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repository
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public User Find(string username, string password)
        {
            return FindAll(x => x.Username == username && x.Password == password).SingleOrDefault();
        }
    }
}
