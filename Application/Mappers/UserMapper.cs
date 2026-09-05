using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.Interfaces.Users;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    public class UserMapper : IUserMapper
    {
        public UserMapper() { }

        public User MapRequest(UserRequest request)
        {
            var user = new User();

            user.Name = request.Name;
            user.Email = request.Email;
            user.Password = request.Password;

            return user;
        }

        public List<User> MapRequestList(List<UserRequest> requests)
        {
            List<User> list = new List<User>();
            foreach (UserRequest request in requests)
            {
                var user = this.MapRequest(request);
                list.Add(user);
            }

            return list;
        }

        public UserResponse MapResponse(User user)
        {
            var response = new UserResponse();

            response.Id = user.Id;
            response.Name = user.Name;
            response.TotalScore = user.TotalScore;
            response.Configs = user.Configs;

            return response;
        }

        public List<UserResponse> MapResponseList(List<User> users)
        {
            List<UserResponse> list = new List<UserResponse>();
            foreach (User user in users)
            {
                var response = this.MapResponse(user);
                list.Add(response);
            }

            return list;
        }
    }
}
