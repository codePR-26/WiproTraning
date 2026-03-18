using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FoodDeliveryApp.Data;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FoodController : ControllerBase
{
    private readonly AppDbContext _context;

    public FoodController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/food
    [AllowAnonymous]
    [HttpGet]
    public IActionResult GetFoods()
    {
        var foods = _context.Foods.ToList();
        return Ok(foods);
    }

    // POST: api/food
    [Authorize(Roles = "Admin")]
    [HttpPost]
    public IActionResult AddFood(Food food)
    {
        _context.Foods.Add(food);
        _context.SaveChanges();
        return Ok(food);
    }
}