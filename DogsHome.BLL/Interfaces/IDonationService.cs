using System;
using System.Collections.Generic;
using DogsHome.BLL.DTO;

namespace DogsHome.BLL.Interfaces
{
    public interface IDonationService { 

        void MakeDonation(DonationDTO donationDto); //donation
        DogDTO GetDog(int? id); //select dog for donation
        IEnumerable<DogDTO> GetDogs(); //get all dogs
        void Dispose();
    }
}
