using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Bakery.Domain;
using Bakery.ProductServices;
using Bakery.ProductServices.Models;
namespace Bakery.ProductServices.UnitTest
{
    public class ProductServiceTest
    {
        [Fact]
        public void CreateProductServiceTest()
        {
            IBakeryRepository repository = new RepositoryEmulator();
            IProductService service = new ProductService(repository);
            Assert.IsType<ProductService>(service);
        }
        [Fact]
        public void GetProductsFromServiceTest()
        {
            IBakeryRepository repository = new RepositoryEmulator();
            IProductService service = new ProductService(repository);
            var products = service.GetProducts();
            var expected = 1;
            Assert.Equal(products.Count(),expected);
        }
        [Fact]
        public void CreateProductsFromServiceTest()
        {
            IBakeryRepository repository = new RepositoryEmulator();
            IProductService service = new ProductService(repository);
            ProductModel product = new ProductModel()
            {
                Id = 0,
                Name = "pan de hojas",
                Price = 140,
                Quantity = 105,
                Category = "panes"
            };
            var productCreated = service.CreateProduct(product);
            var nameExpected = "pan de hojas";
            var priceExpected = 140;
            var quantityExpected = 105;
            var categoryExpected = "panes";
            Assert.Equal(productCreated.Name,nameExpected);
            Assert.Equal(productCreated.Price,priceExpected);
            Assert.Equal(productCreated.Quantity,quantityExpected);
            Assert.Equal(productCreated.Category,categoryExpected);
            var products = service.GetProducts();
            var expected = 2;
            Assert.Equal(products.Count(),expected);
        }
    }
}
