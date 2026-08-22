using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Request
{
    public class QuestionRequest
    {
        public string QuestionName { get; set; }
        public List<string> Options { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
    }
}
