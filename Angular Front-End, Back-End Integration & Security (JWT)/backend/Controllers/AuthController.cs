
using Microsoft.AspNetCore.Mvc;

namespace NestInn.Controllers
{

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{

[HttpPost("login")]
public IActionResult Login()
{

var token="generated_jwt_token";

return Ok(new { token = token });

}

}
}
