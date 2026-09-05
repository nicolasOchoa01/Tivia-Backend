using Application.Interfaces.Configs;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Querys
{
    public class ConfigQuery : IConfigQuery
    {
        private readonly AppDbContext _context;

        public ConfigQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Config>> GetAllConfig()
        {
            return await _context.Configs.ToListAsync();
        }

        public Task<Config> GetConfig(string id)
        {
            return _context.Configs.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<List<Config>> GetDefaultsConfig()
        {
            return _context.Configs.Where(c => 
                c.Name == "standard" | 
                c.Name == "expert" |
                c.Name == "easy")
                .ToListAsync();   
        }

        public async Task<List<Config>> GetPersonalConfig(string userId)
        {
            var user = await _context.Users
                .Where(u => u.Id == userId)
                .Select(u => u.Configs)
                .FirstOrDefaultAsync();


            if (user == null || !user.Any())
            {
                return new List<Config>();
            }

            var configs = await _context.Configs
                .Where(c => user.Contains(c.Id))
                .ToListAsync();

            return configs;
            
        }

    }
}
