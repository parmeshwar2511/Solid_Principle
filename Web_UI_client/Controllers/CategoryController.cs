using BAL;
using System.Web.Mvc;

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

        //    ApplicationDbLogger.Debug("Category Index Execution Started...");
            // List<Category> => List<CategoryViewModel>
            var categories = _catBl.GetAll();

          //  ApplicationDbLogger.Debug("Category Index Execution Complated...");


            return View(categories);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var category = _catBl.GetById(id);
            return View(category);
        }
        [HttpDelete]
        public ActionResult Delete()
        {
            return View();
        }

       

    }
}