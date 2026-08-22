using Application.Interfaces.Histories;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Commands
{
    public class HistoryCommand : IHistoryCommand
    {
        private readonly AppDbContext _context;

        public HistoryCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task SetHistory(History history)
        {
            _context.Histories.Add(history);
            await _context.SaveChangesAsync();
        }
    }
}
