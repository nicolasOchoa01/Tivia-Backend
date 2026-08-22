using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Response
{
    public class HistoryResponse
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public int Score { get; set; }
        public List<string> Category { get; set; }
        public int QuestionsTotal { get; set; }
        public int QuestionsCorrect { get; set; }
        public bool MultipleChoice { get; set; }
        public bool Random { get; set; }
        public bool Timer { get; set; }
        public int Seconds { get; set; }
        public string Date { get; set; }
    }
}
