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
        private readonly IConfigCommand _command;
        private readonly IConfigQuery _query;

        public ConfigService(IConfigCommand command, IConfigQuery query)
        {
            _command = command;
            _query = query;
        }

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
