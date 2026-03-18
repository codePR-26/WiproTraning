using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly FoodDeliveryContext _context;
        public ProductsController(FoodDeliveryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Products p) 
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_context.Products.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Products p) 
        {
            _context.Products.Update(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(_context.Products.Find(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(Products p) 
        {
            _context.Products.Remove(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}