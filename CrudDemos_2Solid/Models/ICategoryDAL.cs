using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDemos_2Solid.Models
{
    public  interface ICategoryDAL
    {
        List<category> GetCategories();

        category GetCategoryById(int id);

        void Create(category category);

        void Update(category category);
        void Delete (int id);   
    }
}
