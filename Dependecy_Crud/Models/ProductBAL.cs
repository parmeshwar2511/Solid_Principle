using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dependecy_Crud.Models
{
    public class ProductBAL : IProductBAL
    {
        IproductRepository _productRepository;

        public ProductBAL(IproductRepository ProductRepository)
        {
            _productRepository = ProductRepository;
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
            var products = _productRepository.GetAll();

            foreach (Product product in products)
            {
                product.name = product.name.ToUpper();
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