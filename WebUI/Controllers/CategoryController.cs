using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Controllers.Logger;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        
        ICategoryBL _catBl;
      

        public CategoryController(ICategoryBL catBl)
        {
            _catBl = catBl;
          
        }


        // GET: Category
        public ActionResult Index()
        {

            ApplicationDbLogger.Debug("Category Index Execution Started...");
           // List<Category> => List<CategoryViewModel>
             var categories = _catBl.GetAll();

            ApplicationDbLogger.Debug("Category Index Execution Complated...");


            return View(categories);
        }
    }
}