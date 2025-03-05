using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudDemos_2Solid.Models
{
    public class ProductRepository : IProductRepository
    {
        ProductDbContext _db;

        public ProductRepository(ProductDbContext db)
        { 
          _db = db;
        }

        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _db.Products.ToList();   
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}