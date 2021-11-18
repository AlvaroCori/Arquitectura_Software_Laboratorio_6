using System;
using Bakery.Domain;
using Bakery.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.ProductOverviewService.UnitTest
{
    public class RepositoryEmulator : IBakeryRepository
    {
        ICollection<ProductEntity> _products;
        public RepositoryEmulator()
        {
            _products = new List<ProductEntity>();
            _products.Add(
                new ProductEntity()
                {
                    Id = 1,
                    Name = "pan de canela",
                    Price = 60,
                    Quantity = 20,
                    Category = "panes"
                });
            _products.Add(
                new ProductEntity()
                {
                    Id = 2,
                    Name = "pan de hoja",
                    Price = 30,
                    Quantity = 20,
                    Category = "panes"
                });
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
