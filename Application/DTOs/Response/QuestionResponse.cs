using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Response
{
    public class QuestionResponse
    {
        public string Id { get; set; }
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
    }
}
