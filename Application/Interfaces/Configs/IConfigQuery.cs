using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Configs
{
    public interface IConfigQuery
    {
        Task<List<Config>> GetAllConfig();

    }
}
