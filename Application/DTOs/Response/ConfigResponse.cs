using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Response
{
    public class ConfigResponse
    {
        public string Id { get; set; }
        public bool Timer { get; set; }
        public int Seconds { get; set; }
        public int NumberQuestions { get; set; }
        public bool MultipleChoice { get; set; }
        public bool Random { get; set; }
        public List<string> Category { get; set; }
    }
}
