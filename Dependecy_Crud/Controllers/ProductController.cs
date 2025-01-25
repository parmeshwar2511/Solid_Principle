using Dependecy_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dependency_Crud.Controllers
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
            // ProductDbContext1 db = new ProductDbContext1();

            var products = _bal.GetAll().
                Select(p => p.name.ToUpper());

            return View(products);
        }
    }
}