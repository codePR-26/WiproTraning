
namespace NestInn.Models
{
 public class OTPVerification
 { 
  public int Id {get;set;} // otp verifi id
  public int UserId {get;set;}
  public string Code {get;set;}
  public System.DateTime ExpiresAt {get;set;} // 30 sec timers
  public bool IsUsed {get;set;}
 }
}
