using System;
using DogsHome.Domain.Contracts;

namespace DogsHome.Domain.Models
{
    public class DogUpdateModel : IDogIdentity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
    }
}
