
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace NestInn.Controllers
{
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{

[HttpPost("login")]
public IActionResult Login()
{
var token="sample_jwt_token";

Response.Cookies.Append("nestinn_token", token);

return Ok(token);
}

[Authorize]
[HttpGet("me")]
public IActionResult Me()
{
return Ok("session active");
}

[HttpPost("logout")]
public IActionResult Logout()
{
Response.Cookies.Delete("nestinn_token");

return Ok();
}

}
}
