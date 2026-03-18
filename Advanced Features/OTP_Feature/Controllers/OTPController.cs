
using Microsoft.AspNetCore.Mvc;
using NestInn.Models;
using NestInn.Data;
using System.Linq;

namespace NestInn.Controllers
{
 [ApiController]
 [Route("api/otp")] // using for otp function..
 public class OTPController:ControllerBase
 {
  private readonly AppDbContext db;

  public OTPController(AppDbContext context)
  {
   db=context;
  }

  [HttpPost("verify")]  //this is Verify the opts
  public IActionResult Verify(OTPVerification o)
  {
   var item=db.OTPVerifications.FirstOrDefault(x=>x.UserId==o.UserId && x.Code==o.Code);

   if(item==null) return BadRequest();

   item.IsUsed=true;
   db.SaveChanges();

   return Ok();
  }
 }
}
