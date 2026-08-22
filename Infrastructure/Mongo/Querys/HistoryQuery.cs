using Application.Interfaces.Histories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Querys
{
    public class HistoryQuery : IHistoryQuery
    {
        private readonly AppDbContext _context;

        public HistoryQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<History>> GetAllHistories()
        {
            return await _context.Histories.ToListAsync();
        }

        public async Task<List<History>> GetHistoryByName(string name)
        {
            var histories = await _context.Histories
                .Where(h => h.Username == name)
                .ToListAsync();

            return histories;
        }
    }
}
