using Application.DTOs.Request;
using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Questions
{
    public interface IQuestionService
    {
        Task<QuestionResponse> SetQuestion(QuestionRequest request);
        Task<List<QuestionResponse>> GetQuestionsByCategory(string category, int cantidad);
    }
}
