using Application.Interfaces.Configs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Commands
{
    public class ConfigCommand : IConfigCommand
    {
        public Task SetConfig(Config config)
        {
            throw new NotImplementedException();
        }
    }
}
