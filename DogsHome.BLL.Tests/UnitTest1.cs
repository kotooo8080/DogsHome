using NUnit.Framework;
using DogsHome.BLL.DTO;

namespace DogsHome.BLL.Tests
{
    public class Tests
    {
        DonationDTO test_donate = new DonationDTO();
     
        [Test]
        public void Test1() {
            Assert.AreEqual(false, test_donate.Gift);
        }
        [Test]
        public void Test2() {
            Assert.IsNull(test_donate.GiftType);
        }
    }
}