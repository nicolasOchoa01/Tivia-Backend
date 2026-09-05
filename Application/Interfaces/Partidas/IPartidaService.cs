using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Partidas
{
    public interface IPartidaService
    {
        Task<PartidaResponse> GetPartida(string configId);
    }
}
