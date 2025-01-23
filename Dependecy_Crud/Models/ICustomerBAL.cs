using System.Collections.Generic;

namespace Dependecy_Crud.Models
{
    public  interface ICustomerBAL
    {
        List<Category> GetCategories();

        Category GetCategoryById(int id);

        void Create(Category category);

        void Update(Category category);

        void Delete(int id);

    }
}
