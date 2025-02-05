using Microsoft.AspNetCore.Mvc;

namespace MVC_JAN_2025.Controllers
{
        public class SampleController : Controller
        {
            // GET: /Sample/
            public IActionResult Index()
            {
                ViewData["Message"] = "Welcome to the Sample Index page!";
                return View();  // Will render Views/Sample/Index.cshtml
            }

            // GET: /Sample/Details/5
            public IActionResult Details(int id)
            {
                ViewData["Message"] = $"You are viewing details for item with ID: {id}";
                return View();  // Will render Views/Sample/Details.cshtml
            }
        }
}
