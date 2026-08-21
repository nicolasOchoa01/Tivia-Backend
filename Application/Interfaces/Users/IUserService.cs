using Application.DTOs.Request;
using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Users
{
    public interface IUserService
    {
        Task SetUser(UserRequest user);
        Task DeleteUser(UserRequest user);
        Task<List<UserResponse>> GetAllUsers();
        Task<UserResponse> Login(string username, string password);
        Task<UserResponse> Register(string usernameOrEmail, string password);
    }
}
