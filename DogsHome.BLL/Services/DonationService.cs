using System;
using System.Collections.Generic;
using AutoMapper;
using DogsHome.BLL.BusinessModels;
using DogsHome.BLL.DTO;
using DogsHome.BLL.Infrastructure;
using DogsHome.BLL.Interfaces;
using DogsHome.DAL.Entities;
using DogsHome.DAL.Interfaces;

namespace DogsHome.BLL.Services
{
    public class DonationService : IDonationService
    {
        IUnitOfWork Database { get; set; }
        public DonationService(IUnitOfWork uow) {
            Database = uow;
        }
        public void MakeDonation(DonationDTO donationDto)
        {
            Dog dog = Database.Dogs.Get(donationDto.Id);
            Donation donat = new Donation
            {
                Id = donationDto.Id,
                Sum = donationDto.Sum,
                PhoneNumber = donationDto.PhoneNumber,
                Address = donationDto.Address,
                Gift = false,
                GiftType = "",
                DogId = donationDto.DogId,
                Dog = dog,
                Date = donationDto.Date
            };
            if (dog == null)
                throw new ValidationException("Dog wasn't selected", "");
            bool gift = new GiftClass().givingGift(donat);
            donat.Gift = gift;
            Database.Donations.Create(donat);
            Database.Save();
        }

        public IEnumerable<DogDTO> GetDogs() {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Dog, DogDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Dog>, List<DogDTO>>(Database.Dogs.GetAll());
        }

        public DogDTO GetDog(int? id)
        {
            if (id == null)
                throw new ValidationException("Dog's id not installed", "");
            var dog = Database.Dogs.Get(id.Value);
            if (dog == null)
                throw new ValidationException("Dog wasn't found", "");

            return new DogDTO { Id = dog.Id, Name = dog.Name, Breed = dog.Breed, Age = dog.Age };
        }
        public void Dispose() {
            Database.Dispose();
        }
    }
}
