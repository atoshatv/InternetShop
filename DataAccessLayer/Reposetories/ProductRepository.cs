using DataAccessLayer.Data;
using DataAccessLayer.Interfaces;
using Domain.Models;

namespace DataAccessLayer.Reposetories
{
    public class ProductRepository : IProductRepository
    {
        public Product Create(Product model)
        {
            using (var database = new EntityDataBase()) {
                var entry = database.Products.Add(model);
                return entry.Entity;
            }
        }

        public bool Delete(Product model)
        {
            using (var database = new EntityDataBase())
            {
                var entity = database.Products.First(p => p.Id == model.Id);
                var entry = database.Products.Remove(entity);
                return true;
            }
        }

        public Product Read(Guid id)
        {
            using (var database = new EntityDataBase())
            {
                return database.Products.First(p => p.Id == id);
            }
        }

        public List<Product> Select()
        {
            using (var database = new EntityDataBase())
            {
                return database.Products.ToList();
            }
        }

        public Product Update(Product model)
        {
            using (var database = new EntityDataBase())
            {
                var entry = database.Products.Update(model);
                return entry.Entity;
            }
        }
    }
}
