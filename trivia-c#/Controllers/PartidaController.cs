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
        public async Task<IActionResult> GetNewPartida([FromQuery]string configId)
        {
            PartidaResponse result = await _partidaService.GetPartida(configId);
            return new JsonResult(result) { StatusCode = 200 };
        }
    }
}
