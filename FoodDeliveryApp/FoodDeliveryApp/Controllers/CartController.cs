using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FoodDeliveryApp.Data;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Only logged-in users can add/view cart
public class CartController : ControllerBase
{
    private readonly AppDbContext _context;

    public CartController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/cart
    [HttpGet("{userId}")]
    public IActionResult GetCart(int userId)
    {
        var cartItems = _context.Carts
            .Where(c => c.CustomerId == userId)
            .ToList();

        return Ok(cartItems);
    }

    // POST: api/cart
    [HttpPost]
    public IActionResult AddToCart(Cart cart)
    {
        cart.TotalAmount = cart.Qty * cart.Price;
        _context.Carts.Add(cart);
        _context.SaveChanges();
        return Ok(cart);
    }
}