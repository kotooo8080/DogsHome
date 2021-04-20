using System;
using System.Collections.Generic;
using DogsHome.BLL.DTO;
using DogsHome.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogsHome.webAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogController: ControllerBase
    {
        IDonationService donationService;
        public DogController(IDonationService service1)
        {
            donationService = service1;
        }

        [HttpGet]
        public IEnumerable<DogDTO> Get()
        {
            return donationService.GetDogs();
        }

        [HttpGet("{id}")]
        public DogDTO Get(int id)
        {
            return donationService.GetDog(id);
        }
    }
}
