
using Microsoft.AspNetCore.Mvc;
using NestInn.Data;
using NestInn.Models;

namespace NestInn.Controllers
{

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{

private readonly AppDbContext db;

public UserController(AppDbContext context)
{
db = context;
}

[HttpGet]
public IActionResult GetUsers()
{
var list = db.Users.ToList();
return Ok(list);
}

[HttpPost]
public IActionResult CreateUser(User u)
{
db.Users.Add(u);
db.SaveChanges();
return Ok(u);
}

[HttpPut("{id}")]
public IActionResult UpdateUser(int id , User u)
{
var item = db.Users.Find(id);

if(item == null) return NotFound();

item.Name = u.Name;
item.Email = u.Email;

db.SaveChanges();

return Ok(item);
}

[HttpDelete("{id}")]
public IActionResult DeleteUser(int id)
{
var item = db.Users.Find(id);

if(item == null) return NotFound();

db.Users.Remove(item);

db.SaveChanges();

return Ok();
}

}
}
