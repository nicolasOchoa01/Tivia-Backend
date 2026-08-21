using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Questions
{
    public interface IQuestionQuery
    {
        Task<List<Question>> GetQuestionsByCategory(string category, int cantidad);
    }
}
