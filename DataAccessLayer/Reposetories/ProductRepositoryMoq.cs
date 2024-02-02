using DataAccessLayer.Data;
using DataAccessLayer.Interfaces;
using Domain.Models;

namespace DataAccessLayer.Reposetories
{
    public class ProductRepositoryMoq : IProductRepository
    {
        public Product Create(Product model)
        {
            DataBaseMoq.Products.Add(model);
            return model;
        }

        public bool Delete(Product model)
        {
            DataBaseMoq.Products.RemoveAll(p => p.Id == model.Id);
            return true;
        }

        public Product Read(Guid id)
        {
            return DataBaseMoq.Products.First(p => p.Id == id);
        }

        public List<Product> Select()
        {
            return DataBaseMoq.Products;
        }

        public Product Update(Product model)
        {
            var index = DataBaseMoq.Products.IndexOf(model);
            DataBaseMoq.Products[index] = model;
            return DataBaseMoq.Products[index];
        }
    }
}
