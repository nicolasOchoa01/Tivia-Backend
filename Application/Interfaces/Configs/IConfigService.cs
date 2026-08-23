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
        Task<ConfigResponse> SetConfig(ConfigRequest request);
        Task<List<ConfigResponse>> GetAllConfig();
    }
}
