using DAL;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public  interface ICategoryBL
    {
       

        List<CategoryViewModel> GetAll();
        CategoryViewModel GetById(int id);
        void Create(CategoryViewModel category);
        void Update(CategoryViewModel category);
        void Delete(int id);
    }
}
