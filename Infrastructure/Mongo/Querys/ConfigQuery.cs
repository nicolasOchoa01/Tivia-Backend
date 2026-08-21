using Application.Interfaces.Configs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Querys
{
    public class ConfigQuery : IConfigQuery
    {
        public Task<List<Config>> GetAllConfig()
        {
            throw new NotImplementedException();
        }
    }
}
