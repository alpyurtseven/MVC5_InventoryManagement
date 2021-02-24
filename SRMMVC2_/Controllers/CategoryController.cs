using SRMMVC2_.Models.Classes;
using System.Linq;
using System.Web.Mvc;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private Context cn = new Context();

        // GET: Category
        public ActionResult Index()
        {
            var values = cn.Categorys.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            cn.Categorys.Add(c);
            cn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCategory(int id)
        {
            var category = cn.Categorys.Find(id);
            cn.Categorys.Remove(category);
            cn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetCategory(int id)
        {
            var category = cn.Categorys.Find(id);
            return View("GetCategory", category);
        }

        public ActionResult UpdateCategory(Category c)
        {
            var category = cn.Categorys.Find(c.CategoryId);
            category.CategoryName = c.CategoryName;
            cn.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}