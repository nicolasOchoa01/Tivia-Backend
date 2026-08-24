using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Request
{
    public class UserLogin
    {
        public string NameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
