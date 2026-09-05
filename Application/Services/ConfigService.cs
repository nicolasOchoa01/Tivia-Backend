using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Configs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
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

        public async Task<AllConfigsResponse> GetAllConfig(string userId)
        {
            var defualts = await _query.GetDefaultsConfig();
            var personalConfigs = await _query.GetPersonalConfig(userId);
            var responsePersonal = _mapper.MapResponseList(personalConfigs); 
            var responseDefaults = _mapper.MapResponseList(defualts);

            var allConfigs = new AllConfigsResponse();
            allConfigs.Standard = responseDefaults.Find(config => config.Name == "standard");
            allConfigs.Expert = responseDefaults.Find(config => config.Name == "expert");
            allConfigs.Easy = responseDefaults.Find(config => config.Name == "easy");
            allConfigs.PersonalConfigs = responsePersonal;

            return allConfigs;
        }

        public async Task<ConfigResponse> GetConfig(string id)
        {
            var config = await _query.GetConfig(id);
            var response = _mapper.MapResponse(config);
            return response;
        }

        public async Task<ConfigResponse> SetConfig(ConfigRequest request)
        {

            var config = _mapper.MapRequest(request);
            await _command.SetConfig(config);
            var response = _mapper.MapResponse(config);
            return response;
        }
    }
}
