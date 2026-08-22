using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Configs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ConfigService : IConfigService
    {
        private readonly IConfigCommand _command;
        private readonly IConfigQuery _query;
        private readonly IConfigMapper _mapper;
        public ConfigService(IConfigCommand command, IConfigQuery query, IConfigMapper mapper)
        {
            _command = command;
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<ConfigResponse>> GetAllConfig()
        {
            var configs = await _query.GetAllConfig();
            var response = _mapper.MapResponseList(configs);
            return response;
        }

        public async Task SetConfig(ConfigRequest request)
        {
            var config = _mapper.MapRequest(request);
            await _command.SetConfig(config);
        }
    }
}
