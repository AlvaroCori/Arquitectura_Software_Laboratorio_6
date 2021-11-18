using System;
using Bakery.ProductServices.Models;
using System.Collections.Generic;
namespace Bakery.ProductServices
{
    public interface IProductService
    {
        ICollection<ProductModel> GetProducts();
        ProductModel CreateProduct(ProductModel newProduct);
    }
}
