using System.Collections.Generic;

namespace Dependecy_Crud.Models
{
    public interface IProductBAL
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Create(Product product);
        void Update(Product product);

        void Delete(int id);
    }
}