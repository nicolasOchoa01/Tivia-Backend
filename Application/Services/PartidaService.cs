using Application.DTOs.Response;
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

        public PartidaService(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public async Task<PartidaResponse> GetPartida(Config config)
        {
            List<QuestionResponse> questions = new List<QuestionResponse>();
            int numberForCategory = config.NumberQuestions / config.Category.Count;

            foreach (string category in config.Category) {
                var questionsByCategory = await _questionService.GetQuestionsByCategory(category, config.NumberQuestions);
                questions.AddRange(questionsByCategory);
            }
            
            PartidaResponse partida = new PartidaResponse();
            partida.Config = config;
            partida.Questions = questions;

            return partida;
        }

        
    }
}
