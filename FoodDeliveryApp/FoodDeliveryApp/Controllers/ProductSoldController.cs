using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FoodDeliveryApp.Data;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Controllers
{ 


[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ProductSoldController : ControllerBase
{
    private readonly AppDbContext _context;
    public ProductSoldController(AppDbContext context)
    {
        _context = context;
    }


    // POST: api/ProductSold
    [HttpPost]
    public IActionResult AddProductSold(ProductsSold productSold)
    {
        _context.ProductsSold.Add(productSold);
        _context.SaveChanges();
        return Ok(productSold);
    }

    // GET: api/ProductSold/{saleId}
    [HttpGet("{saleId}")]
    public IActionResult GetProductsSoldBySaleId(int saleId)
    {
        var productsSold = _context.ProductsSold
            .Where(ps => ps.SaleId == saleId)
            .ToList();

        return Ok(productsSold);
    }
}
}