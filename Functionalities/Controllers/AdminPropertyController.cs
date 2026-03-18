
using Microsoft.AspNetCore.Mvc;
using NestInn.Data;
using NestInn.Models;

namespace NestInn.Controllers
{

[ApiController]
[Route("api/admin/properties")]
public class AdminPropertyController : ControllerBase
{

private readonly AppDbContext db;

public AdminPropertyController(AppDbContext context)
{
db = context;
}

[HttpGet]
public IActionResult GetAll()
{
return Ok(db.Properties.ToList());
}

[HttpPost]
public IActionResult Add(Property p)
{
db.Properties.Add(p);
db.SaveChanges();
return Ok(p);
}

[HttpPut("{id}")]
public IActionResult Update(int id , Property p)
{
var item = db.Properties.Find(id);

if(item == null) return NotFound();

item.Title = p.Title;
item.Price = p.Price;

db.SaveChanges();

return Ok(item);
}

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
var item = db.Properties.Find(id);

if(item == null) return NotFound();

db.Properties.Remove(item);

db.SaveChanges();

return Ok();
}

}
}
