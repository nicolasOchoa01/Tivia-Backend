using Application.DTOs.Response;
using Application.Interfaces.Configs;
using Application.Interfaces.Partidas;
using Application.Interfaces.Questions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class PartidaService : IPartidaService
    {
        private readonly IQuestionService _questionService;
        private readonly IConfigQuery _configQuery;

        public PartidaService(IQuestionService questionService, IConfigQuery configQuery)
        {
            _questionService = questionService;
            _configQuery = configQuery;
        }

        public async Task<PartidaResponse> GetPartida(string configId)
        {
            var config = await _configQuery.GetConfig(configId);
            List<QuestionResponse> questions = new List<QuestionResponse>();
            
            if(config.Category.Count == 0)
            {
                questions = await _questionService.GetQuestionsRandom(config.NumberQuestions);
            }
            else
            {
                int numberForCategory = config.NumberQuestions / config.Category.Count;

                foreach (string category in config.Category)
                {
                    var questionsByCategory = await _questionService.GetQuestionsByCategory(category, numberForCategory);
                    questions.AddRange(questionsByCategory);
                }
            }
            
            
            PartidaResponse partida = new PartidaResponse();
            partida.Config = config;
            partida.Questions = questions;

            return partida;
        }

        
    }
}
