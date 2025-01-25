using Crud_Demos_Using__Scafolding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace Crud_Demos_Using__Scafolding.Controllers
{
    public class CategoryController : Controller
    {
        ProductDbContext _context = new ProductDbContext();
        // GET: Category
        public ActionResult Index()
        {
            List<Category> categories = _context.categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            _context.categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var value = _context.categories.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult Edit (Category category)
        {
            if (category != null)
            {
                var categoryDb = _context.categories.Find(category.Id);

                categoryDb.Name = category.Name;
                categoryDb.Rating = category.Rating;

                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("category");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var del = _context.categories.Find(id);
            return View(del);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            var del= _context.categories.Find(id);

            _context.categories.Remove(del);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
           Category category= _context.categories.Find(id);
           
            return View(category);
        }
    }
}