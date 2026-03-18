
namespace NestInn.Models
{
 public class Message
 {
  public int Id {get;set;} // msg id
  public int SenderId {get;set; } // sender's id
        public int ReceiverId {get;set;}
  public string Content {get;set;}
  public System.DateTime SentAt {get;set;}// calculating time
 }
}
