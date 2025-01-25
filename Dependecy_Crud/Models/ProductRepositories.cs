using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dependecy_Crud.Models
{
    public class ProductRepositories :
         IproductRepository
    { 
       ProductDbContext1 _db;
        public ProductRepositories(ProductDbContext1 db)
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