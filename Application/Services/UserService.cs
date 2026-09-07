using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Configs;
using Application.Interfaces.Users;
using Domain.Entities;
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
        private readonly IConfigService _configService;

        public UserService(IUserCommand command, IUserQuery query, IUserMapper mapper, IConfigService configService)
        {
            _command = command;
            _query = query;
            _mapper = mapper;
            _configService = configService;
        }

        public async Task<bool> DeleteUser(UserRequest request)
        {
            var user = _mapper.MapRequest(request);
            await _command.DeleteUser(user);
            return true;
        }

        public async Task<List<UserResponse>> GetAllUsers()
        {
            var users = await _query.GetAllUsers();
            var response = _mapper.MapResponseList(users);
            return response;
        }

        public async Task<UserResponse> GetUser(string id)
        {
            var user = await _query.GetUserById(id);
            var response = _mapper.MapResponse(user);
            return response;
        }

        public Task<UserResponse> Login(UserLogin user)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> Register(UserRequest user)
        {
            throw new NotImplementedException();
        }

        public async Task<ConfigResponse> SetConfig(ConfigRequest request, string userId)
        {
            var user = await _query.GetUserById(userId);
            var config = await _configService.SetConfig(request);
            user.Configs.Add(config.Id);
            await _command.Update(user);
            
            return config;
        }

        public async Task<UserResponse> SetUser(UserRequest request)
        {
            var user = _mapper.MapRequest(request);
            await _command.SetUser(user);
            var response = _mapper.MapResponse(user);
            return response;
        }

        public async Task<UserResponse> UpdateUser(User update)
        {
            await _command.Update(update);
            var response = _mapper.MapResponse(update);
            return response;
        }
    }
}
