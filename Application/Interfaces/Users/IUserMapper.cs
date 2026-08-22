using Application.DTOs.Request;
using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Users
{
    public interface IUserMapper
    {
        public User MapRequest(UserRequest request);
        public List<User> MapRequestList(List<UserRequest> requests);
        public UserResponse MapResponse(User user);
        public List<UserResponse> MapResponseList(List<User> users);

    }
}
