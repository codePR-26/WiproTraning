using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NestInn.API.Controllers

{[ApiController]
   [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly JwtHelper _jwtHelper;

        public AuthController(IAuthService authService, JwtHelper jwtHelper)
        {
          _authService = authService;
            _jwtHelper = jwtHelper;
        }
        // Here login function is call 
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            try
            {
                var result = await _authService.LoginAsync(dto);

                Response.Cookies.Append("nestinn_token", result.Message, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = false,
                    SameSite = SameSiteMode.Lax,
                    Expires = DateTimeOffset.UtcNow.AddDays(7)
                });

                result.Message = "Login successful";
                return Ok(ApiResponse<AuthResponseDto>.Ok(result, "Login Successful"));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResponse<string>.Fail(ex.Message));
            }
        }

[HttpGet("me")]
        [Authorize]
        public IActionResult Me()
        {
            var userId = _jwtHelper.GetUserIdFromToken(User);
                     var email = User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;
            var role = User.FindFirst(System.Security.Claims.ClaimTypes.Role)?.Value;
                var name = User.FindFirst(System.Security.Claims.ClaimTypes.Name)?.Value;

            return Ok(new
            {
                  UserId = userId,
                Email = email,
            Role = role,
                FullName = name
            });
        }

        [HttpPost("logout")]  // Its succesfull logout func 
        public IActionResult Logout()
        {
            Response.Cookies.Delete("nestinn_token");
            return Ok("Logged out");
        }}}