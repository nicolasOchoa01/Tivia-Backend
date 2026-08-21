using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Histories
{
    public interface IHistoryQuery
    {
        Task<List<History>> GetHistoryByName(string name);
        Task<List<History>> GetAllHistories();
    }
}
