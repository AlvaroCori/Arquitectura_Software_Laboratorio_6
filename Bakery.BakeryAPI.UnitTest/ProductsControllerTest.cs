using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bakery.BakeryAPI.Controllers;
using Bakery.ProductServices;
using Bakery.ProductServices.Models;
namespace Bakery.BakeryAPI.UnitTest
{
    public class ProductsControllerTest
    {
        [Fact]
        public void CreateProductsControllerTest()
        {
            ServiceProductSimulator service = new ServiceProductSimulator(); 
            var controller = new ProductsController(service);
            Assert.IsType<ProductsController>(controller);
        }
        [Fact]
        public void GetProductsFromControllerTest()
        {
            ServiceProductSimulator service = new ServiceProductSimulator(); 
            var controller = new ProductsController(service);
            var result = controller.GetProducts();
            Assert.IsType<ActionResult<IEnumerable<ProductModel>>>(result);
        }
        [Fact]
        public void CreateProductsFromControllerTest()
        {
            ServiceProductSimulator service = new ServiceProductSimulator(); 
            var controller = new ProductsController(service);
            var product = new ProductModel(){Name ="pan de canela", Price=10,Quantity=10,Category="panes"};
            var result = controller.CreateProduct(product);
            Assert.IsType<ActionResult<ProductModel>>(result);
        }
    }
}
