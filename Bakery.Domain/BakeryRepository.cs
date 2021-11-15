using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Domain.Entities;
namespace Bakery.Domain
{
    public class BakeryRepository:IBakeryRepository
    {
        private ICollection<ProductEntity> _products;
        public BakeryRepository(ICollection<ProductEntity> products)
        {
            _products = products;
            _products.Add(
                new ProductEntity()
                {
                    Id = 1,
                    Name = "Pie De Limon",
                    Price = 30,
                    Quantity = 1,
                    Category = "pies"
                }
            );
        }
        public ICollection<ProductEntity> GetProducts()
        {
            return _products;
        }
        public ProductEntity CreateProduct(ProductEntity newProduct)
        {
            var id = _products.OrderByDescending(p=>p.Id).FirstOrDefault().Id + 1;
            newProduct.Id = id;
            _products.Add(newProduct);
            return newProduct;
        }

    }
}
