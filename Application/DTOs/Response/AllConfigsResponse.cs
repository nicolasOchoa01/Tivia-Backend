using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Response
{
    public class AllConfigsResponse
    {
        public ConfigResponse Standard { get; set; }
        public ConfigResponse Expert { get; set; }
        public ConfigResponse Easy { get; set; }
        public List<ConfigResponse> PersonalConfigs { get; set; }

    }
}
