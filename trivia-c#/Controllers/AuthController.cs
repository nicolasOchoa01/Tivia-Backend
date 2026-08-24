using Application.DTOs.Request;
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
        public async Task<IActionResult> Login([FromBody]UserLogin user)
        {
            var result = await _userService.Login(user);
            return new JsonResult(result) { StatusCode = 200 };
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody]UserRequest user)
        {
            var result = await _userService.Register(user);
            return new JsonResult(result) { StatusCode = 200 };
        }
    }
}
