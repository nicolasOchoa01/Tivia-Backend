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
        Task<UserResponse> SetUser(UserRequest request);
        Task<bool> DeleteUser(UserRequest request);
        Task<List<UserResponse>> GetAllUsers();
        Task<UserResponse> Login(string username, string password);
        Task<UserResponse> Register(string username, string email, string password);
    }
}
