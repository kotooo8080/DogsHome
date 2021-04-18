using System;

namespace DogsHome.DAL.Entities
{
    public class Donation
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public int DogId { get; set; }
        public Dog Dog { get; set; }

        public DateTime Date { get; set; }
    }
}