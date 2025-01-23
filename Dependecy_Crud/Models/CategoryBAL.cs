using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dependecy_Crud.Models
{
    //Business Access Layer
    // high level module => CategoryBal
    // Low level module  => CategoryDal

    public class CategoryBAL : ICustomerBAL
    {
        ICategoryDAL dal;
        public CategoryBAL(ICategoryDAL dal)
        {
            this.dal = dal;
        }

        public List<Category> GetCategories()
        {
            //CategoryDAL dal = new CategoryDAL();
            return dal. GetCategories();
        }

        public Category GetCategoryById(int id)
        {
            //CategoryDAL dal = new CategoryDAL();
            return dal.GetCategoryById(id);
        }

        public void Create(Category category)
        {
          //  CategoryDAL dal = new CategoryDAL();
            dal.Create(category);

        }

        public void Update (Category category)
        {
          //  CategoryDAL dal = new CategoryDAL();
            dal.Update(category);

        }

        public void Delete(int id)
        {
          //  CategoryDAL dal = new CategoryDAL();
            dal.Delete(id);
        }

    }
}