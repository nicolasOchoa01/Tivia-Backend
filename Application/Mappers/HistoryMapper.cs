using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Histories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    public class HistoryMapper : IHistoryMapper
    {
        public HistoryMapper() { }

        public History MapRequest(HistoryRequest request)
        {
            var history = new History();

            history.Category = request.Category;
            history.Score = request.Score;
            history.Seconds = request.Seconds;
            history.QuestionsTotal = request.QuestionsTotal;
            history.Date = request.Date;
            history.UserId = request.UserId;
            history.Username = request.Username;
            history.MultipleChoice = request.MultipleChoice;
            history.QuestionsCorrect = request.QuestionsCorrect;
            history.Random = request.Random;
            history.Timer = request.Timer;

            return history;
        }

        public List<History> MapRequestList(List<HistoryRequest> requests)
        {
            List<History> list = new List<History>();
            foreach (HistoryRequest request in requests)
            {
                var history = this.MapRequest(request);
                list.Add(history);
            }

            return list;
        }

        public HistoryResponse MapResponse(History history)
        {
            var response = new HistoryResponse();

            response.Id = history.Id;
            response.Category = history.Category;
            response.Score = history.Score;
            response.Seconds = history.Seconds;
            response.QuestionsTotal = history.QuestionsTotal;
            response.Date = history.Date;
            response.UserId = history.UserId;
            response.Username = history.Username;
            response.MultipleChoice = history.MultipleChoice;
            response.QuestionsCorrect = history.QuestionsCorrect;
            response.Random = history.Random;
            response.Timer = history.Timer;

            return response;
        }

        public List<HistoryResponse> MapResponseList(List<History> histories)
        {
            List<HistoryResponse> list = new List<HistoryResponse>();
            foreach (History history in histories)
            {
                var response = this.MapResponse(history);
                list.Add(response);
            }

            return list;
        }
    }
}
