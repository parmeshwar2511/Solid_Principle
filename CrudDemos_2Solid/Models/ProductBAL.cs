using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudDemos_2Solid.Models
{
    public class ProductBAL : IProductBAL
    {

        IProductRepository _ProductRepository;

        public ProductBAL(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
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
            var products = _ProductRepository.GetAll();

            foreach (Product product in products)
            { 
              product.Name = product.Name.ToUpper();  
            }

            return products;
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