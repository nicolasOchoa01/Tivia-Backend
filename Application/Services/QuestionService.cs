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
        private readonly IQuestionCommand _command;
        private readonly IQuestionQuery _query;
        private readonly IQuestionMapper _mapper;

        public QuestionService(IQuestionCommand command, IQuestionQuery query, IQuestionMapper mapper)
        {
            _command = command;
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<QuestionResponse>> GetQuestionsByCategory(string category, int cantidad)
        {
            var questions = await _query.GetQuestionsByCategory(category, cantidad);
            var response = _mapper.MapResponseList(questions);
            return response;
        }

        public async Task<QuestionResponse> SetQuestion(QuestionRequest request)
        {
            var question = _mapper.MapRequest(request);
            await _command.SetQuestion(question);
            var response = _mapper.MapResponse(question);
            return response;
        }
    }
}
