using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repository
{
    public class OrderRepository : EfRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public override IEnumerable<Order> FindAll()
        {
            return _dbContext.Orders
                .Include(x => x.Payments)
                .Include(x => x.Addresses)
                .Include(x => x.Total)
                .Include(x => x.Articles)
                .ToList();
        }

        public override Order Find(long id)
        {
            return _dbContext.Orders
                .Include(x => x.Payments)
                .Include(x => x.Addresses)
                .Include(x => x.Total)
                .Include(x => x.Articles)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
