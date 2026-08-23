using Application.DTOs.Response;
using Application.Interfaces.Partidas;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace trivia_c_.Controllers
{
    [Route("api/")]
    public class PartidaController : Controller
    {
        private readonly IPartidaService _partidaService;

        public PartidaController(IPartidaService partidaService)
        {
            _partidaService = partidaService;
        }

        [HttpGet("Partida")]
        public async Task<IActionResult> GetNewPartida(Config config)
        {
            PartidaResponse result = await _partidaService.GetPartida(config);
            return new JsonResult(result) { StatusCode = 200 };
        }
    }
}
