using System;
using System.Collections.Generic;
using DogsHome.DAL.Entities;

namespace DogsHome.BLL.BusinessModels
{
    public class GiftClass
    {
        public GiftClass() {}

        public bool givingGift(Donation don1)
        {
            return don1.Sum > 5000;
        }
    }
}
