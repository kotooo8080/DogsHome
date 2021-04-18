using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DogsHome.DAL.Context;
using DogsHome.DAL.Entities;
using DogsHome.DAL.Interfaces;

namespace DogsHome.DAL.Repositories
{
    public class DonationRepository : IRepository<Donation>
    {
        private DogsHomeContext db;

        public DonationRepository(DogsHomeContext context)
        {
            this.db = context;
        }

        public IEnumerable<Donation> GetAll()
        {
            return db.Donations.Include(o => o.Dog);
        }

        public Donation Get(int id)
        {
            return db.Donations.Find(id);
        }

        public void Create(Donation Donation)
        {
            db.Donations.Add(Donation);
        }

        public void Update(Donation Donation)
        {
            db.Entry(Donation).State = EntityState.Modified;
        }
        public IEnumerable<Donation> Find(Func<Donation, Boolean> predicate)
        {
            return db.Donations.Include(o => o.Dog).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Donation Donation = db.Donations.Find(id);
            if (Donation != null)
                db.Donations.Remove(Donation);
        }
    }
}
