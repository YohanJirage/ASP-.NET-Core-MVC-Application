using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb1.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
