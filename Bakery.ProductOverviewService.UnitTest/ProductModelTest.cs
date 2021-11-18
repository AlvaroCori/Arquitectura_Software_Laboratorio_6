using System;
using Xunit;
using Bakery.ProductOverviewService.Models;
namespace Bakery.ProductOverviewService.UnitTest
{
    public class ProductModelTest
    {
        [Fact]
        public void ProductModelIdTest()
        {
            OverviewModel overview = new OverviewModel(){Id = 1};
            var expected = 1;
            Assert.Equal(overview.Id, expected);
        }
        [Fact]
        public void ProductModelNameProductTest()
        {
            OverviewModel overview = new OverviewModel(){NameProduct = "panes"};
            var expected = "panes";
            Assert.Equal(overview.NameProduct, expected);
        }
        [Fact]
        public void ProductModelQuantityTest()
        {
            OverviewModel overview = new OverviewModel(){Quantity = 1024};
            var expected = 1024;
            Assert.Equal(overview.Quantity, expected);
        }
        [Fact]
        public void ProductModelTotalTest()
        {
            OverviewModel overview = new OverviewModel(){Total = 2300};
            var expected = 2300;
            Assert.Equal(overview.Total, expected);
        }
    }
}
