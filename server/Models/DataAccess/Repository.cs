using System.Collections.Generic;
using System.Linq;
using server.Models.Entities;

namespace server.Models.DataAccess
{
    public class Repository : IRepository<Product>
    {
        public readonly Context _context;
        public Repository(Context context)
        {
            _context = context;
        }
        public void Add(Product item)
        {
            _context.Products.Add(item);
            _context.SaveChanges();
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(int id)
        {
            return _context.Products.SingleOrDefault(item => item.Id == id);
        }

        public List<Product> GetByCategory(Category category)
        {
            return _context.Products.Where(item => item.Category == category).ToList();
        }

        public List<Product> GetByItemName(Category category, string itemName)
        {
            return _context.Products.Where(item => item.Category == category && item.Name == itemName).ToList();
        }

        public void Remove(int id)
        {
            _context.Products.Remove(_context.Products.SingleOrDefault(item => item.Id == id));
            _context.SaveChanges();
        }

        public void Update(Product item)
        {
            _context.Products.Update(item);
            _context.SaveChanges();
        }
    }
}