using Microsoft.AspNetCore.Mvc;

namespace MVC_JAN_2025.Controllers
{
    public class ViewTempDataController : Controller
    {
            public IActionResult Index()
            {
                // Example of using ViewData
                ViewData["Message"] = "Hello from ViewData!";
                ViewData["CurrentDate"] = DateTime.Now;

            // some changes from my side
            ViewData["CName"] = "Jaya milk and milk product";

                // Example of using TempData
                TempData["Notification"] = "This is a TempData notification!";

                return View();
            }

            public IActionResult Details(string id)
            {
                // Example of using QueryString
                // Assume the URL is /Example/Details?id=123
                ViewData["QueryStringId"] = id;

                // Access TempData set in a previous request
                ViewData["Notification"] = TempData["Notification"];

                return View();
            }
        }
    }
