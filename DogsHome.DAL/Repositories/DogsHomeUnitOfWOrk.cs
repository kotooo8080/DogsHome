using System;
using DogsHome.DAL.Context;
using DogsHome.DAL.Entities;
using DogsHome.DAL.Interfaces;

namespace DogsHome.DAL.Repositories
{
    public class DogsHomeUnitOfWork : IUnitOfWork
    {
        private DogsHomeContext db;
        private DogRepository dogRepository;
        private DonationRepository donationRepository;

        public DogsHomeUnitOfWork(string connectionString)
        {
            db = new DogsHomeContext(connectionString);
        }
        public IRepository<Dog> Dogs
        {
            get
            {
                if (dogRepository == null)
                    dogRepository = new DogRepository(db);
                return dogRepository;
            }
        }

        public IRepository<Donation> Donations
        {
            get
            {
                if (donationRepository == null)
                    donationRepository = new DonationRepository(db);
                return donationRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
