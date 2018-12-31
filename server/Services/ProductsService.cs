

using System;
using System.Collections.Generic;
using System.Linq;
using server.Models.DataAccess;
using server.Models.Entities;

namespace server.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public List<Product> GetByCategory(Category category)
        {
            var categoryProducts = _repository.GetByCategory(category);
            return categoryProducts;
        }

        public List<Product> GetByItemName(Category category, string itemName)
        {
            var specifiedProducts = _repository.GetByItemName(category, itemName);
            return specifiedProducts;
        }
        
    }
}