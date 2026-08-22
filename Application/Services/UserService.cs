using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserCommand _command;
        private readonly IUserQuery _query;

        public UserService(IUserCommand command, IUserQuery query)
        {
            _command = command;
            _query = query;
        }

        public Task DeleteUser(UserRequest user)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserResponse>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> Register(string usernameOrEmail, string password)
        {
            throw new NotImplementedException();
        }

        public Task SetUser(UserRequest user)
        {
            throw new NotImplementedException();
        }
    }
}
