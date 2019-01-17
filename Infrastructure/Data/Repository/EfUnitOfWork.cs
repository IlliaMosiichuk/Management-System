using ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repository
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public EfUnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
    }
}
