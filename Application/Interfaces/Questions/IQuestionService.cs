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
        Task SetQuestion(QuestionRequest question);
        Task<List<QuestionResponse>> GetQuestionsByCategory(string category, int cantidad);
    }
}
