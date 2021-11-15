using System;
using Bakery.Domain;
using Bakery.Domain.Entities;
using Bakery.Repository.Models;

using System.Collections.Generic;

namespace Bakery.Repository
{
    public class ProductService : IProductService
    {
        private IBakeryRepository _repository;
        public ProductService(IBakeryRepository repository)
        {
            _repository = repository;
        }
        public ProductModel TransformEntityToModel(ProductEntity entityProduct)
        {
            ProductModel productModel = new ProductModel();
            productModel.Id = entityProduct.Id;
            productModel.Name = entityProduct.Name;
            productModel.Price = entityProduct.Price;
            productModel.Quantity = entityProduct.Quantity;
            productModel.Category = entityProduct.Category;
            return productModel; 
        }
        public ProductEntity TransformModelToEntity(ProductModel productModel)
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
