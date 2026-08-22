using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Request
{
    public class UserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
