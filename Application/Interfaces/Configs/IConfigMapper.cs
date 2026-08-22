using Application.DTOs.Request;
using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Configs
{
    public interface IConfigMapper
    {
        public Config MapRequest(ConfigRequest request);
        public List<Config> MapRequestList(List<ConfigRequest> requests);
        public ConfigResponse MapResponse(Config config);
        public List<ConfigResponse> MapResponseList(List<Config> configs);
    }
}
