using System;
using System.Collections.Generic;
using Bakery.ProductOverviewService;
using Bakery.ProductOverviewService.Models;

namespace Bakery.BakeryAPI.UnitTest
{
    public class ServiceOverviewSimulator :IOverviewService
    {
        public ServiceOverviewSimulator()
        {
        }
        public ICollection<OverviewModel> GetOverviews()
        {
            return new List<OverviewModel>();
        }
        
    }
}
