using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Histories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryCommand _command;
        private readonly IHistoryQuery _query;

        public HistoryService(IHistoryCommand command, IHistoryQuery query)
        {
            _command = command;
            _query = query;
        }

        public Task<List<HistoryResponse>> GetAllHistories()
        {
            throw new NotImplementedException();
        }

        public Task<List<HistoryResponse>> GetHistoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task SetHistory(HistoryRequest history)
        {
            throw new NotImplementedException();
        }
    }
}
