using Dependecy_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dependecy_Crud.Controllers
{

    // high level module  Category Controller
    // low Level module =>  CategoryBal
    public class CategoryController : Controller
    {
        ICustomerBAL bal;

        public CategoryController(ICustomerBAL bal)
        { 
            this.bal = bal;
        }

        ProductDbContext1 _context = new ProductDbContext1();
        // GET: Category
        public ActionResult Index()
        {
           // CategoryBAL bal = new CategoryBAL();
            var categories = bal.GetCategories();


            //List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid) 
                {
                    _context.Categories.Add(category);
                    _context.SaveChanges(); 
                    return RedirectToAction("Index");
                }
                else
                {
                    
                    return View(category);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);

            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
               
                var data=_context.Categories.Find(id);
                if (data != null)
                {


                    data.name = category.name;
                    data.Rating = category.Rating;
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    return HttpNotFound();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                var category = _context.Categories.Find(id);
                _context.Categories.Remove(category);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
