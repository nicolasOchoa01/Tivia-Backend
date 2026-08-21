using Application.Interfaces.Users;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Commands
{
    public class UserCommand : IUserCommand
    {
        public Task DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task SetUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
