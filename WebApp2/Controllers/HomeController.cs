using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly FoodDeliveryContext _context;

        public HomeController(FoodDeliveryContext context)
        {
            _context = context;
        }

        // Show form
        public IActionResult Index()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // Save form data
        [HttpPost]
        public IActionResult Index(Products product) // <-- Change Product to Products
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index", "Products");
        }
    }
}
