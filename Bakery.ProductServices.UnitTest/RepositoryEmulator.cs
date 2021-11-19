using System;
using Bakery.DBBakeryRepository;
using Bakery.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
namespace Bakery.ProductServices.UnitTest
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
        }
        public ICollection<ProductEntity> GetProducts()
        {
            return _products;
        }
        public ProductEntity CreateProduct(ProductEntity newProduct)
        {
            _products.Add(newProduct);
            
            return newProduct;
        }
    }
}