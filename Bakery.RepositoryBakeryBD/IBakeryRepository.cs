using System;
using System.Collections.Generic;
using Bakery.Domain.Entities;
namespace Bakery.DBBakeryRepository
{
    public interface IBakeryRepository
    {
        ICollection<ProductEntity> GetProducts();
        ProductEntity CreateProduct(ProductEntity newProduct);
    }
}
