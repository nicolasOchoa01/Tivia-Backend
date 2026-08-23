using Application.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace trivia_c_.Controllers
{
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var result = await _userService.Login(username, password);
            return new JsonResult(result) { StatusCode = 200 };
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(string username, string email, string password)
        {
            var result = await _userService.Register(username, email, password);
            return new JsonResult(result) { StatusCode = 200 };
        }
    }
}
