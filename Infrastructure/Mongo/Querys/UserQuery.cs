using Application.Interfaces.Users;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Querys
{
    public class UserQuery : IUserQuery
    {
        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
