using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Question
    {
        public string Id { get; set; }
        public string QuestionName {  get; set; }
        public List<string> Options { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
    }
}
