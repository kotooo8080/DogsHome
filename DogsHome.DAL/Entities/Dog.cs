﻿using System.Collections.Generic;

namespace DogsHome.DAL.Entities
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public ICollection<Donation> Donations { get; set; }

    }
}