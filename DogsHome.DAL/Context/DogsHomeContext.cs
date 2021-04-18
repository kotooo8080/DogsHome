using System;
using System.Data.Entity;
using DogsHome.DAL.Entities;

namespace DogsHome.DAL.Context
{
    public class DogsHomeContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Donation> Donations { get; set; }

        static DogsHomeContext()
        {
            Database.SetInitializer<DogsHomeContext>(new StoreDbInitializer());
        }
        public DogsHomeContext(string connectionString)
            : base(connectionString)
        {
        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DogsHomeContext>
    {
        protected override void Seed(DogsHomeContext db)
        {
            db.Dogs.Add(new Dog { Name = "Ветерок", Breed = "Хаски", Age = 7 });
            db.Dogs.Add(new Dog { Name = "Гонщик", Breed = "Венгерская выжла", Age = 6 });
            db.Dogs.Add(new Dog { Name = "Фуфик", Breed = "Самоед", Age = 2 });
            db.Dogs.Add(new Dog { Name = "Дюшес", Breed = "Лабрадор", Age = 1 });
            db.SaveChanges();
        }
    }
}
