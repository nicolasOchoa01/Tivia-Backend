using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Users
{
    public interface IUserQuery
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByName(string name);
        Task<User> GetUserByEmail(string email);
    }
}
