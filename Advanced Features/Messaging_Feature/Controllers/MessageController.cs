
using Microsoft.AspNetCore.Mvc;
using NestInn.Models;
using NestInn.Data;
using System.Linq;

namespace NestInn.Controllers
{
 [ApiController]   
 [Route("api/messages")] // its basically use for massage function.
 public class MessageController:ControllerBase
 {
  private readonly AppDbContext db;

        public MessageController(AppDbContext context)
        {
            db = context;
        }
        

  [HttpGet("{userId}")]  // this use to recive massages
  public IActionResult GetMessages(int userId)
  {
   var list=db.Messages.Where(x=>x.SenderId==userId || x.ReceiverId==userId).ToList();
   return Ok(list);
  }

  [HttpPost]  // i use it to send massages
  
            public IActionResult Send(Message m)
  {
   db.Messages.Add(m);
     db.SaveChanges();
   return Ok(m);
  }}}
