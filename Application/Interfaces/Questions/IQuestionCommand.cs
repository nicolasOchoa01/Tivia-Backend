using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Questions
{
    public interface IQuestionCommand
    {
        Task SetQuestion(Question question);
    }
}
