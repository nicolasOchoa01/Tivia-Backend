using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Response
{
    public class PartidaResponse
    {
        public Config Config {  get; set; }
        public List<Question> Questions { get; set; }
    }
}
