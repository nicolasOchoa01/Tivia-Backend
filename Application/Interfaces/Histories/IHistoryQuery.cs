using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Histories
{
    public interface IHistoryQuery
    {
        Task<List<History>> GetHistoryByUserId(string userId);
        Task<List<History>> GetAllHistories();
    }
}
