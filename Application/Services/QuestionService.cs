using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class QuestionService : IQuestionService
    {
        public Task<List<QuestionResponse>> GetQuestionsByCategory(string category, int cantidad)
        {
            throw new NotImplementedException();
        }

        public Task SetQuestion(QuestionRequest question)
        {
            throw new NotImplementedException();
        }
    }
}
