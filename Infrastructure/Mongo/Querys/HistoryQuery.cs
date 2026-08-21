using Application.Interfaces.Histories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Querys
{
    public class HistoryQuery : IHistoryQuery
    {
        public Task<List<History>> GetAllHistories()
        {
            throw new NotImplementedException();
        }

        public Task<List<History>> GetHistoryByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
