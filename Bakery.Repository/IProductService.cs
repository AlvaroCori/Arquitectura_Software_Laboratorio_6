using System;
using Bakery.Repository.Models;
using System.Collections.Generic;
namespace Bakery.Repository
{
    public interface IProductService
    {
        ICollection<ProductModel> GetProducts();
        ProductModel CreateProduct(ProductModel newProduct);

    }
}
