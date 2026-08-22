using Application.Interfaces.Configs;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Commands
{
    public class ConfigCommand : IConfigCommand
    {
        private readonly AppDbContext _context;
        public ConfigCommand(AppDbContext context) {
            _context = context;
        }
        public async Task SetConfig(Config config)
        {
            _context.Configs.Add(config);
            await _context.SaveChangesAsync();
        }
    }
}
