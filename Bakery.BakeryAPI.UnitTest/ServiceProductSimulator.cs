using System;
using System.Collections.Generic;
using Bakery.ProductServices;
using Bakery.ProductServices.Models;
namespace Bakery.BakeryAPI.UnitTest
{
    public class ServiceProductSimulator : IProductService
    {
        public ServiceProductSimulator()
        {

        }
        public ICollection<ProductModel> GetProducts()
        {
            return new List<ProductModel>();
        }
        public ProductModel CreateProduct(ProductModel newProduct)
        {
            return newProduct;
        }
    }
}
