using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Histories;
using Application.Interfaces.Users;
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
        private readonly IUserCommand _userCommand;
        private readonly IUserQuery _userQuery;

        public HistoryService(IHistoryCommand command, IHistoryQuery query, IHistoryMapper mapper, IUserCommand userCommand, IUserQuery userQuery)
        {
            _command = command;
            _query = query;
            _mapper = mapper;
            _userCommand = userCommand;
            _userQuery = userQuery;
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
            var user = await _userQuery.GetUserById(request.UserId);
            if(user == null)
            {
                throw new Exception("User not found");
            }
            user.TotalScore += request.Score;
            await _userCommand.Update(user);

            var history = _mapper.MapRequest(request);
            await _command.SetHistory(history);
            var response = _mapper.MapResponse(history);
            return response;
        }
    }
}
