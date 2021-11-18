using System;
using Xunit;
using Bakery.Domain.Entities;

namespace Bakery.DomainTest
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
    }
}
