using Application.DTOs.Request;
using Application.Interfaces.Configs;
using Application.Interfaces.Histories;
using Application.Interfaces.Questions;
using Application.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace trivia_c_.Controllers
{
    [Route("api/Insert")]
    public class InsertController : Controller
    {
        private readonly IConfigService _configService;
        private readonly IUserService _userService;
        private readonly IQuestionService _questionService;
        private readonly IHistoryService _historyService;

        public InsertController(IConfigService configService, IUserService userService, IQuestionService questionService, IHistoryService historyService)
        {
            _configService = configService;
            _userService = userService;
            _questionService = questionService;
            _historyService = historyService;
        }

        [HttpPost("User")]
        public async Task<IActionResult> SetUser(UserRequest user)
        {
            var result = await _userService.SetUser(user);
            return new JsonResult(result) { StatusCode = 201 };
        }

        [HttpPost("Config")]
        public async Task<IActionResult> SetConfig(ConfigRequest config)
        {
            var result = await _configService.SetConfig(config);
            return new JsonResult(result) { StatusCode = 201 };
        }

        [HttpPost("Question")]
        public async Task<IActionResult> SetQuestion(QuestionRequest question)
        {
            var result = await _questionService.SetQuestion(question);
            return new JsonResult(result) { StatusCode = 201 };
        }

        [HttpPost("History")]
        public async Task<IActionResult> SetHistory(HistoryRequest history)
        {
            var result = await _historyService.SetHistory(history);
            return new JsonResult(result) { StatusCode = 201 };
        }
    }
}
