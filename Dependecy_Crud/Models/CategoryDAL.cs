using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace Dependecy_Crud.Models
{
   // date Access Layer
   // low level module = productDbContext


    public class CategoryDAL : ICategoryDAL
    {
        ProductDbContext1 db = new ProductDbContext1();

        //ProductDbContext db;
        public CategoryDAL(ProductDbContext1 db)
        {
            this.db = db;
        }

        public List<Category> GetCategories()
        {
            //ProductDbContext db = new ProductDbContext();
            var categories = db.Categories.ToList();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
           // ProductDbContext db = new ProductDbContext();
            var category = db.Categories.Find(id);
            return category;
        }

        public void Create(Category category)
        {
           // ProductDbContext db = new ProductDbContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Update(Category category)
        {
           // ProductDbContext db = new ProductDbContext();
            db.Entry<Category>(category).State = EntityState.Modified;
            db.SaveChanges();
        }

        
        public void Delete (int id)
        {
           // ProductDbContext db = new ProductDbContext();
            var category = db.Categories.Find(id);

            db.Categories.Remove(category);
            db.SaveChanges();

        }

       
    }
}