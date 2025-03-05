using CrudDemos_2Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudDemos_2Solid.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryBAL bal;

        public CategoryController(ICategoryBAL bal)
        { 
          this.bal = bal;
        }


        // GET: Category
        public ActionResult Index()
        {
           // CategoryBAL bal = new CategoryBAL();
            var categories = bal.GetCategories();

            return View(categories);
        }
    }
}