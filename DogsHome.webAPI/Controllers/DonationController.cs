using System;
using DogsHome.BLL.DTO;
using DogsHome.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogsHome.webAPI.Controllers
{
    [Route("api/[controller]")]
    public class DonationController : Controller
    {
        IDonationService donationService;
        public DonationController(IDonationService service1) {
            donationService = service1;
        }
        [HttpPost]
        public void Post([FromBody] DonationDTO newDonate)
        {
            donationService.MakeDonation(newDonate);
        }
    }
}
