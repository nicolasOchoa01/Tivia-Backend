using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Users
{
    public interface IUserCommand
    {
        Task SetUser(User user);
        Task DeleteUser(User user);
        Task Update(User user);
    }
}
