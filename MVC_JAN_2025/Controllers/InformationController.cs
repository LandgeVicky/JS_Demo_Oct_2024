using Microsoft.AspNetCore.Mvc;

namespace MVC_JAN_2025.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            ViewData["Message"] = "Welcome to the Home page!";
            return View();  // This will render Views/Home/Index.cshtml
        }

        // GET: /Home/About
        public IActionResult About()
        {
            ViewData["Title"] = "About Page";
            ViewData["Message"] = "This is the About page.";
            return View();  // This will render Views/Home/About.cshtml
        }

    }
}
