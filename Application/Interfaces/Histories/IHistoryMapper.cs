using Application.DTOs.Request;
using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Histories
{
    public interface IHistoryMapper
    {
        public History MapRequest(HistoryRequest request);
        public List<History> MapRequestList(List<HistoryRequest> requests);
        public HistoryResponse MapResponse(History history);
        public List<HistoryResponse> MapResponseList(List<History> histories);
    }
}
