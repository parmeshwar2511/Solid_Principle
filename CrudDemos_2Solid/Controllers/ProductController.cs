using CrudDemos_2Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudDemos_2Solid.Controllers
{

    public class ProductController : Controller
    {

        IProductBAL _bal;

        public ProductController(IProductBAL bal)
        {
            _bal = bal;
        }

        // GET: Product
        public ActionResult Index()
        {
            // ProductDbContext db = new ProductDbContext();

            var products = _bal.GetAll();

            return View(products);
        }
    }
}