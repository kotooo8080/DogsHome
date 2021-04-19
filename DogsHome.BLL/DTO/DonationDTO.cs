﻿using System;
using DogsHome.DAL.Entities;

namespace DogsHome.BLL.DTO
{
    public class DonationDTO
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Gift { get; set; }
        public string GiftType { get; set; }
        public int DogId { get; set; }
        public Dog Dog { get; set; }

        public DateTime Date { get; set; }

        public static implicit operator DonationDTO(int v)
        {
            throw new NotImplementedException();
        }
    }
}
