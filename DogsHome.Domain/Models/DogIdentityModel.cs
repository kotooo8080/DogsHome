using System;
using DogsHome.Domain.Contracts;

namespace DogsHome.Domain.Models
{
    public class DogIdentityModel : IDogIdentity
    {
        public int Id { get; }
        public DogIdentityModel(int id) 
        {
            this.Id = id;
        }
    }
}
