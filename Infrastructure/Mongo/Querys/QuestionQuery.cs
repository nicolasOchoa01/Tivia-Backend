using Application.Interfaces.Questions;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Querys
{
    public class QuestionQuery : IQuestionQuery
    {
        private readonly AppDbContext _context;

        public QuestionQuery(AppDbContext context) {
            _context = context;
        }

        public async Task<List<Question>> GetQuestionsByCategory(string category, int cantidad)
        {
            var questions = await _context.Questions
                .Where(q => q.Category == category)
                .Take(cantidad)
                .ToListAsync();

            return questions;
        }

        public async Task<List<Question>> GetQuestionsRandom(int cantidad)
        {
            var allIds = await _context.Questions
                .Select(q => q.Id)
                .ToListAsync();

            if (allIds.Count == 0)
            {
                return new List<Question>();
            }

            var randomIds = allIds
                .OrderBy(id => Guid.NewGuid())
                .Take(cantidad)
                .ToList();

            var questions = await _context.Questions
                .Where(q => randomIds.Contains(q.Id))
                .ToListAsync();

            return questions;
        }
    }
}
