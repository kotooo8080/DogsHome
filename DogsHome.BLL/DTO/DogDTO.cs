using System;
using System.Collections.Generic;
using DogsHome.DAL.Entities;

namespace DogsHome.BLL.DTO
{
    public class DogDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public ICollection<Donation> Donations { get; set; }
    }
}

