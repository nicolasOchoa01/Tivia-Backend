using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Response
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int TotalScore { get; set; }
        public List<string> Configs { get; set; }
    }
}
