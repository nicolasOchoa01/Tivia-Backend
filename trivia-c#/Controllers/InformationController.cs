using Application.Interfaces.Configs;
using Application.Interfaces.Histories;
using Application.Interfaces.Questions;
using Application.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace trivia_c_.Controllers
{
    [Route("api/")]
    public class InformationController : Controller
    {
        private readonly IUserService _userService;
        private readonly IConfigService _configService;
        private readonly IQuestionService _questionService;
        private readonly IHistoryService _historyService;

        public InformationController(IUserService userService, IConfigService configService, IQuestionService questionService, IHistoryService historyService)
        {
            _userService = userService;
            _configService = configService;
            _questionService = questionService;
            _historyService = historyService;
        }

        [HttpGet("Config")]
        public async Task<IActionResult> GetAllConfig([FromQuery]string userId)
        {
            var result = await _configService.GetAllConfig(userId);
            return new JsonResult(result) { StatusCode = 200 };
        }

        [HttpGet("User")]
        public async Task<IActionResult> GetAllUser()
        {
            var result = await _userService.GetAllUsers();
            return new JsonResult(result) { StatusCode = 200 };
        }

        [HttpGet("Question")]
        public async Task<IActionResult> GetAllQuestionByCategory(string category, int cantidad)
        {
            var result = await _questionService.GetQuestionsByCategory(category, cantidad);
            return new JsonResult(result) {StatusCode = 200 };
        }

        [HttpGet("History")]
        public async Task<IActionResult> GetAllHistory()
        {
            var result = await _historyService.GetAllHistories();
            return new JsonResult(result) {StatusCode = 200 };
        }
    }
}
