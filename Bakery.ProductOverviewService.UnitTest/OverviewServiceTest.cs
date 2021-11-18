using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Bakery.ProductOverviewService;
using Bakery.ProductOverviewService.Models;
namespace Bakery.ProductOverviewService.UnitTest
{
    public class OverviewServiceTest
    {
        [Fact]
        public void CreateAOverviewService()
        {
            RepositoryEmulator repository = new RepositoryEmulator();
            IOverviewService service = new OverviewService(repository);
            Assert.IsType<OverviewService>(service);
        }
        [Fact]
        public void GetOverview()
        {
            RepositoryEmulator repository = new RepositoryEmulator();
            OverviewService service = new OverviewService(repository);
            var overview = service.GetOverview("panes");
            var expected = 2;
            Assert.Equal(overview.Quantity, expected);
        }
        [Fact]
        public void GetOverviews()
        {
            RepositoryEmulator repository = new RepositoryEmulator();
            OverviewService service = new OverviewService(repository);
            var overviews = service.GetOverviews();
            var expected = 1;
            Assert.Equal(overviews.Count(), expected);
        }
    }
}
