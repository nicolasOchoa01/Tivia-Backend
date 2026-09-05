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
        Task<AllConfigsResponse> GetAllConfig(string userId);
        Task<ConfigResponse> GetConfig(string id);
    }
}
