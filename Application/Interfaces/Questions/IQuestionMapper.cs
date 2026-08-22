using Application.DTOs.Request;
using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Questions
{
    public interface IQuestionMapper
    {
        public Question MapRequest(QuestionRequest request);
        public List<Question> MapRequestList(List<QuestionRequest> requests);
        public QuestionResponse MapResponse(Question question);
        public List<QuestionResponse> MapResponseList(List<Question> questions);

    }
}
