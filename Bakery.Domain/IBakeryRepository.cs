using System;
using System.Collections.Generic;
using Bakery.Domain.Entities;

namespace Bakery.Domain
{
    public interface IBakeryRepository
    {
        ICollection<ProductEntity> GetProducts();
        ProductEntity CreateProduct(ProductEntity newProduct);
    }
}
