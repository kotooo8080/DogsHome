using System;
using DogsHome.DAL.Entities;

namespace DogsHome.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Dog> Dogs { get; }
        IRepository<Donation> Donations { get; }
        void Save();
    }
}
