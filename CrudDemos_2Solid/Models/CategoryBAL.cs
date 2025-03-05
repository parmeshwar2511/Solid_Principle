using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudDemos_2Solid.Models
{
    // BAL => Business Access layer
    public class CategoryBAL : ICategoryBAL
    {
        ICategoryDAL dal;

        public CategoryBAL(ICategoryDAL dal)
        { 
          this.dal = dal;
        }
        public List<category> GetCategories()
        { 
         // CategoryDAL dal = new CategoryDAL();
            return dal.GetCategories();
        }

        public category GetCategoryById(int id)
        {
           // CategoryDAL dal = new CategoryDAL();
            return dal.GetCategoryById(id);
        }

        public void Create(category category)
        {
           // CategoryDAL dal = new CategoryDAL();
            dal.Create(category);
        }

        public void Update(category category)
        {
           // CategoryDAL dal = new CategoryDAL();
            dal.Update(category);
        }

        public void Delete(int id)
        {
            //CategoryDAL dal = new CategoryDAL();
            dal.Delete(id);
        }

    }
}   