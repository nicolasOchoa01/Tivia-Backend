using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Configs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ConfigService : IConfigService
    {
        public Task<List<ConfigResponse>> GetAllConfig()
        {
            throw new NotImplementedException();
        }

        public Task SetConfig(ConfigRequest config)
        {
            throw new NotImplementedException();
        }
    }
}
