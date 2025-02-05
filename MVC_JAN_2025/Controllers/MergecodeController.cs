using Microsoft.AspNetCore.Mvc;

namespace MVC_JAN_2025.Controllers
{
    public class MergecodeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to the Sample Index page!";
            return View();  // Will render Views/Sample/Index.cshtml        }
        }
    }
}
