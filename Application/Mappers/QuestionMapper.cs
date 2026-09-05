using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Questions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    public class QuestionMapper : IQuestionMapper
    {
        public QuestionMapper() { }

        public Question MapRequest(QuestionRequest request)
        {
            var question = new Question();

            question.Answer = request.Answer;
            question.Options = request.Options;
            question.QuestionName = request.Question;
            question.Category = request.Category;

            return question;
        }

        public List<Question> MapRequestList(List<QuestionRequest> requests)
        {
            List<Question> list = new List<Question>();
            foreach (QuestionRequest request in requests)
            {
                var question = this.MapRequest(request);
                list.Add(question);
            }

            return list;
        }

        public QuestionResponse MapResponse(Question question)
        {
            var response = new QuestionResponse();

            response.Id = question.Id;
            response.Answer = question.Answer;
            response.Options = question.Options;
            response.Question = question.QuestionName;
            response.Category = question.Category;

            return response;
        }

        public List<QuestionResponse> MapResponseList(List<Question> questions)
        {
            List<QuestionResponse> list = new List<QuestionResponse>();
            foreach (Question question in questions)
            {
                var response = this.MapResponse(question);
                list.Add(response);
            }

            return list;
        }
    }
}
