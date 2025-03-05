using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CrudDemos_2Solid.Models
{

  // Data Access Layer
    public class CategoryDAL : ICategoryDAL
    {
        // ProductDbContext db = new ProductDbContext();
        ProductDbContext db;
        public CategoryDAL(ProductDbContext db)
        {
            this.db = db;
        }

        public List<category> GetCategories()
        { 
        // ProductDbContext db = new ProductDbContext();
            var categories = db.categories.ToList();
            return categories;
        }

        public category GetCategoryById(int id)
        {
           // ProductDbContext db = new ProductDbContext();
            var category = db.categories.Find(id);
            return category;
        }

        public void Create(category category)
        {
           // ProductDbContext db = new ProductDbContext();
            db.categories.Add(category);
            db.SaveChanges();
        }

        public void Update(category category)
        {
           // ProductDbContext db = new ProductDbContext();
            db.Entry<category>(category).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)  
        {
            // ProductDbContext db = new ProductDbContext();
            var Category = db.categories.Find(id);

            db.categories.Remove(Category);
            db.SaveChanges();
        }
    }
}