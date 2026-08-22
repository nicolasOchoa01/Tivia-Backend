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
        private readonly IUserMapper _mapper;

        public UserService(IUserCommand command, IUserQuery query, IUserMapper mapper)
        {
            _command = command;
            _query = query;
            _mapper = mapper;
        }

        public async Task DeleteUser(UserRequest request)
        {
            var user = _mapper.MapRequest(request);
            await _command.DeleteUser(user);
        }

        public async Task<List<UserResponse>> GetAllUsers()
        {
            var users = await _query.GetAllUsers();
            var response = _mapper.MapResponseList(users);
            return response;
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
