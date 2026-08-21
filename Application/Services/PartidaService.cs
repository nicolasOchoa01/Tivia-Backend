using Application.DTOs.Response;
using Application.Interfaces.Partidas;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class PartidaService : IPartidaService
    {
        public Task<PartidaResponse> GetPartida(Config config)
        {
            throw new NotImplementedException();
        }
    }
}
