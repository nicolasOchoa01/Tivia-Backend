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
        private readonly IHistoryMapper _mapper;

        public HistoryService(IHistoryCommand command, IHistoryQuery query, IHistoryMapper mapper)
        {
            _command = command;
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<HistoryResponse>> GetAllHistories()
        {
            var histories = await _query.GetAllHistories();
            var response = _mapper.MapResponseList(histories);
            return response;
        }

        public async Task<List<HistoryResponse>> GetHistoryByUserId(string userId)
        {
            var histories = await _query.GetHistoryByUserId(userId);
            var response = _mapper.MapResponseList(histories);
            return response;
        }

        public async Task<HistoryResponse> SetHistory(HistoryRequest request)
        {
            var history = _mapper.MapRequest(request);
            await _command.SetHistory(history);
            var response = _mapper.MapResponse(history);
            return response;
        }
    }
}
