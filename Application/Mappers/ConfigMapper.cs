using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Configs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    public class ConfigMapper : IConfigMapper
    {
        public ConfigMapper() { }
        public Config MapRequest(ConfigRequest request)
        {
            Config config = new Config();

            config.Random = request.Random;
            config.MultipleChoice = request.MultipleChoice;
            config.NumberQuestions = request.NumberQuestions;
            config.Seconds = request.Seconds;
            config.Category = request.Category;
            config.Timer = request.Timer;

            return config;
        }

        public List<Config> MapRequestList(List<ConfigRequest> requests)
        {
            List<Config> list = new List<Config>();
            foreach (ConfigRequest request in requests)
            {
                var config = this.MapRequest(request);
                list.Add(config);
            }

            return list;
        }

        public ConfigResponse MapResponse(Config config)
        {
            ConfigResponse response = new ConfigResponse();

            response.Id = config.Id;
            response.Random = config.Random;
            response.MultipleChoice = config.MultipleChoice;
            response.NumberQuestions = config.NumberQuestions;
            response.Seconds = config.Seconds;
            response.Category = config.Category;
            response.Timer = config.Timer;

            return response;
        }

        public List<ConfigResponse> MapResponseList(List<Config> configs)
        {
            List<ConfigResponse> list = new List<ConfigResponse>();
            foreach(Config config in configs)
            {
                var response = this.MapResponse(config);
                list.Add(response);
            }

            return list;
        }
    }
}
