using Application.DTOs.Request;
using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Configs
{
    public interface IConfigService
    {
        Task SetConfig(ConfigRequest config);
        Task<List<ConfigResponse>> GetAllConfig();
    }
}
