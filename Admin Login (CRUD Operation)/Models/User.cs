namespace NestInn.API.Models
{
    public class User
    {
        public int Id { get; set; } // this is user id 
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } // I use it for password hashing
        public string Role { get; set; } // role define 
    }
}