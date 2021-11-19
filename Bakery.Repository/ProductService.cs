using System;
using Bakery.DBBakeryRepository;
using Bakery.Domain.Entities;
using Bakery.ProductServices.Models;
using System.Collections.Generic;

namespace Bakery.ProductServices
{
    public class ProductService : IProductService
    {
        private IBakeryRepository _repository;
        public ProductService(IBakeryRepository repository)
        {
            _repository = repository;
        }
        private ProductModel TransformEntityToModel(ProductEntity entityProduct)
        {
            ProductModel productModel = new ProductModel();
            productModel.Id = entityProduct.Id;
            productModel.Name = entityProduct.Name;
            productModel.Price = entityProduct.Price;
            productModel.Quantity = entityProduct.Quantity;
            productModel.Category = entityProduct.Category;
            return productModel; 
        }
        private ProductEntity TransformModelToEntity(ProductModel productModel)
        {
            ProductEntity productEntity = new ProductEntity();
            productEntity.Id = productModel.Id;
            productEntity.Name = productModel.Name;
            productEntity.Price = productModel.Price;
            productEntity.Quantity = productModel.Quantity;
            productEntity.Category = productModel.Category;
            return productEntity; 
        }
        public ICollection<ProductModel> GetProducts()
        {
            var models = new List<ProductModel>();
            ProductModel modelProduct= null;
            var entities = _repository.GetProducts();
            foreach (ProductEntity entity in entities)
            {
                modelProduct = TransformEntityToModel(entity);
                models.Add(modelProduct);
            }
            return models;
        }
        public ProductModel CreateProduct(ProductModel newProduct)
        {
            ProductEntity entityProduct = TransformModelToEntity(newProduct);
            entityProduct = _repository.CreateProduct(entityProduct);
            newProduct = TransformEntityToModel(entityProduct);
            return newProduct;
        }

    }
}
