using ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                Username = "admin",
                Password = "1234",
            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Country> Countries { get; set; }


        public DbSet<Address> Addresses { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Total> Totals { get; set; }

    }

}
