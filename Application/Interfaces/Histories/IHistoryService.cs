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
        Task SetHistory(HistoryRequest history);
        Task<List<HistoryResponse>> GetHistoryByName(string name);
        Task<List<HistoryResponse>> GetAllHistories();


    }
}
