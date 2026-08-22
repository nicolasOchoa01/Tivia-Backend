using Application.Interfaces.Questions;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Commands
{
    public class QuestionCommand : IQuestionCommand
    {
        private readonly AppDbContext _context;

        public QuestionCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task SetQuestion(Question question)
        {
            _context.Questions.Add(question);
            await _context.SaveChangesAsync();
        }
    }
}
