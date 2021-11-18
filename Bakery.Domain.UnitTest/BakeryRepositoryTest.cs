using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Bakery.Domain;
using Bakery.Domain.Entities;
namespace Bakery.Domain.UnitTest
{
    public class BakeryRepositoryTest
    {
        [Fact]
        public void CreateBakeryRepositoryTest()
        {
            IBakeryRepository repository = new BakeryRepository();
            Assert.IsType<BakeryRepository>(repository);
        }
        [Fact]
        public void GetProductsFromRepositoryTest()
        {
            IBakeryRepository repository = new BakeryRepository();
            var products = repository.GetProducts();
            Assert.IsType<List<ProductEntity>>(products);
        }
        [Fact]
        public void CreateProductFromRepositoryTest()
        {
            IBakeryRepository repository = new BakeryRepository();
            ProductEntity product = new ProductEntity(){
                Name = "pastel de queso",
                Price = 20,
                Quantity = 4,
                Category = "pastelillos"
            };
            var productCreated = repository.CreateProduct(product);
            var nameRequest = "pastel de queso";
            var priceRequest = 20;
            var quantityRequest = 4;
            var categoryRequest = "pastelillos";
            Assert.True(productCreated.Id != 0);
            Assert.Equal(productCreated.Name, nameRequest);
            Assert.Equal(productCreated.Price, priceRequest);
            Assert.Equal(productCreated.Quantity, quantityRequest);
            Assert.Equal(productCreated.Category, categoryRequest);
        }
       
    }
}
