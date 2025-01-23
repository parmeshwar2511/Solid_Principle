using Dependecy_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dependecy_Crud.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductDbContext1 db = new ProductDbContext1();

            var products = db.Products.ToList();

            return View(products);
        }
    }
}