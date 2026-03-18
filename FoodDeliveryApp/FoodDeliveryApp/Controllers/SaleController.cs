using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FoodDeliveryApp.Data;
using FoodDeliveryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Only logged-in users can create sales
public class SaleController : ControllerBase
{
    private readonly AppDbContext _context;

    public SaleController(AppDbContext context)
    {
        _context = context;
    }

    // POST: api/sale
    [HttpPost]
    public IActionResult CreateSale([FromBody] Sale sale)
    {
        // Only UserId is required from POST
        sale.Date = DateTime.Now;
        sale.Status ??= "Pending"; // set default if null

        // Calculate TotalAmount from Cart
        var cartItems = _context.Carts
            .Where(c => c.CustomerId == sale.UserId)
            .Include(c => c.Food)
            .ToList();

        if (cartItems.Count == 0)
            return BadRequest("Cart is empty");

        sale.TotalAmount = cartItems.Sum(c => c.TotalAmount);

        _context.Sales.Add(sale);
        _context.SaveChanges();

        // Add ProductsSold
        foreach (var item in cartItems)
        {
            _context.ProductsSold.Add(new ProductsSold
            {
                SaleId = sale.SaleId,
                ProductId = item.ProductId,
                Qty = item.Qty,
                TotalProductAmount = item.TotalAmount,
                Status = "Sold"
            });
        }
        _context.SaveChanges();

        // Clear cart
        _context.Carts.RemoveRange(cartItems);
        _context.SaveChanges();

        return Ok(new
        {
            sale,
            productsSold = _context.ProductsSold.Where(ps => ps.SaleId == sale.SaleId).ToList()
        });
    }

    // GET: api/sale/{userId}
    [HttpGet("{userId}")]
    public IActionResult GetUserSales(int userId)
    {
        var sales = _context.Sales
            .Where(s => s.UserId == userId)
            .ToList();

        return Ok(sales);
    }
}