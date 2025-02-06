using Microsoft.AspNetCore.Mvc;

namespace MVC_JAN_2025.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Product List";
            ViewData["Message"] = "Here are some products:";
            return View();  // This will render Views/Product/Index.cshtml
        }

        // GET: /Product/Details/5
        public IActionResult Details(int id)
        {
            ViewData["Title"] = "Product Details";
            ViewData["Message"] = $"Details for Product ID: {id}";
            return View();  // This will render Views/Product/Details.cshtml
        }

        // GET: /Product/Create
        public IActionResult Create()
        {
            ViewData["Title"] = "Create Product";
            return View();  // This will render Views/Product/Create.cshtml
        }

    }
}
