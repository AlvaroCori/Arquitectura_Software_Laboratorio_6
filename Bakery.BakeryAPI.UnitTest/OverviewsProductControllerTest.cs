using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Bakery.BakeryAPI.Controllers;
using Bakery.ProductOverviewService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
///using System.Text;
///using System.Threading.Tasks;


namespace Bakery.BakeryAPI.UnitTest
{
    public class OverviewsProductControllerTest
    {
        [Fact]
        public void CreateOverviewsProductControllerTest()
        {
            ServiceOverviewSimulator service = new ServiceOverviewSimulator(); 
            var controller = new OverviewsProductController(service);
            Assert.IsType<OverviewsProductController>(controller);
        }
        [Fact]
        public void GetOverviewsFromControllerTest()
        {
            ServiceOverviewSimulator service = new ServiceOverviewSimulator(); 
            var controller = new OverviewsProductController(service);
            var result = controller.GetOverviews();
            Assert.IsType<ActionResult<IEnumerable<OverviewModel>>>(result);
        }
    }
}
