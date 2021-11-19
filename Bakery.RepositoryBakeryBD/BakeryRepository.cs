using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Domain.Entities;
namespace Bakery.DBBakeryRepository
{
    public class BakeryRepository:IBakeryRepository
    {
        private ICollection<ProductEntity> _products;
        public BakeryRepository()
        {
            _products = new List<ProductEntity>();
            _products.Add(
                new ProductEntity()
                {
                    Id = 1,
                    Name = "Pie De Limon",
                    Price = 30,
                    Quantity = 1,
                    Category = "pies"
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
            _products.Add(
                new ProductEntity()
                {
                    Id = 3,
                    Name = "pan dulce",
                    Price = 40,
                    Quantity = 30,
                    Category = "panes"
                });
            _products.Add(
                new ProductEntity()
                {
                    Id = 4,
                    Name = "pan de hojas",
                    Price = 140,
                    Quantity = 105,
                    Category = "panes"
                });
            _products.Add(
                new ProductEntity()
                {
                    Id = 5,
                    Name = "pie de fresa",
                    Price = 50,
                    Quantity = 2,
                    Category = "pies"
                });
            _products.Add(
                new ProductEntity()
                {
                    Id = 6,
                    Name = "pie de mora",
                    Price = 35,
                    Quantity = 1,
                    Category = "pies"
                });
            _products.Add(
                new ProductEntity()
                {
                    Id = 7,
                    Name = "pastel de 3 pisos",
                    Price = 230,
                    Quantity = 1,
                    Category = "pasteles"
                });
            _products.Add(
                new ProductEntity()
                {
                    Id = 8,
                    Name = "pastel de maracuya",
                    Price = 100,
                    Quantity = 2,
                    Category = "pasteles"
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
