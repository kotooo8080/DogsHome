using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DogsHome.DAL.Context;
using DogsHome.DAL.Entities;
using DogsHome.DAL.Interfaces;

namespace DogsHome.DAL.Repositories
{
    public class DogRepository : IRepository<Dog>
    {
        private DogsHomeContext db;

        public DogRepository(DogsHomeContext context)
        {
            this.db = context;
        }

        public IEnumerable<Dog> GetAll()
        {
            return db.Dogs;
        }

        public Dog Get(int id)
        {
            return db.Dogs.Find(id);
        }

        public void Create(Dog dog)
        {
            db.Dogs.Add(dog);
        }

        public void Update(Dog dog)
        {
            db.Entry(dog).State = EntityState.Modified;
        }

        public IEnumerable<Dog> Find(Func<Dog, Boolean> predicate)
        {
            return db.Dogs.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Dog dog = db.Dogs.Find(id);
            if (dog != null)
                db.Dogs.Remove(dog);
        }
    }
}
