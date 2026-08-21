using Application.Interfaces.Questions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Querys
{
    public class QuestionQuery : IQuestionQuery
    {
        public Task<List<Question>> GetQuestionsByCategory(string category, int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
