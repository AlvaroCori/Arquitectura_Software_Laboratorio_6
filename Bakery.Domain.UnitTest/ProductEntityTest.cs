using System;
using Xunit;
using Bakery.Domain.Entities;
namespace Bakery.Domain.UnitTest
{
    public class ProductEntityTest
    {
        [Fact]
        public void ProductEntityIdTest()
        {
            ProductEntity product = new ProductEntity()
            {Id = 1};
            var expected = 1;
            Assert.Equal(product.Id, expected);
        }
        [Fact]
        public void ProductEntityNametest()
        {
            ProductEntity product = new ProductEntity()
            {Name = "pan de soya"};
            var expected = "pan de soya";
            Assert.Equal(product.Name, expected);
        }
        [Fact]
        public void ProductEntityPriceTest()
        {
            ProductEntity product = new ProductEntity()
            {Price = 100};
            var expected = 100;
            Assert.Equal(product.Price, expected);
        }
        [Fact]
        public void ProductEntityQuantityTest()
        {
            ProductEntity product = new ProductEntity()
            {Quantity = 100};
            var expected = 100;
            Assert.Equal(product.Quantity, expected);
        }
        [Fact]
        public void ProductEntityCategoryTest()
        {
            ProductEntity product = new ProductEntity()
            {Category = "panes"};
            var expected = "panes";
            Assert.Equal(product.Category, expected);
        }
    }
}
