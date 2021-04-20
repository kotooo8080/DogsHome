using System;
using Microsoft.EntityFrameworkCore;
using DogsHome.DAL.Entities;

namespace DogsHome.DAL.Context
{
    public class DogsHomeContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DogsHomeContext(DbContextOptions<DogsHomeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
