using System.Collections.Generic;
using server.Models.Entities;

namespace server.Services
{
    public interface IProductService
    {
        List<Product> GetByCategory(Category category);
        List<Product> GetByItemName(Category category, string itemName);
    }
}