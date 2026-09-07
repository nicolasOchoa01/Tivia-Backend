using Application.DTOs.Request;
using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Histories
{
    public interface IHistoryService
    {
        Task<HistoryResponse> SetHistory(HistoryRequest request);
        Task<List<HistoryResponse>> GetHistoryByUserId(string userId);
        Task<List<HistoryResponse>> GetAllHistories();


    }
}
