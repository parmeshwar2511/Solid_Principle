using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Crud.Models
{
    public  interface ICategoryDAL
    {
        List<Category> GetCategories();

        Category GetCategoryById(int id);

        void Create(Category category);

        void Update(Category category);

        void Delete(int id);
    }
}
