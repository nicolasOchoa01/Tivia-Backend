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
    }
}
