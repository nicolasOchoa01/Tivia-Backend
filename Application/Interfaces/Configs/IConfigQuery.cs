using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Configs
{
    public interface IConfigQuery
    {
        Task<List<Config>> GetAllConfig();
        Task<List<Config>> GetDefaultsConfig();
        Task<List<Config>> GetPersonalConfig(string userId);
        Task<Config> GetConfig(string id);
    }
}
