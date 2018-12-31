using System.Collections.Generic;
using System.Linq;
using server.Models.Entities;

namespace server.Models.DataAccess
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        List<T> GetByCategory(Category category);
        List<T> GetByItemName(Category category, string itemName);
        void Add(T item);
        void Remove(int id);
        void Update(T item);
    }
}