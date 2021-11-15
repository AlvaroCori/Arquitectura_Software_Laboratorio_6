using System;
using System.Collections.Generic;
using Bakery.Service.Models;

namespace Bakery.BreadService
{
    public interface IProductService
    {
        ICollection<ProductModel> GetProducts();
        ProductModel CreateProdutc(ProductModel newProduct);
    }
}
