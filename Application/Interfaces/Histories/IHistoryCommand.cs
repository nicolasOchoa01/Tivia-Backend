using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Histories
{
    public interface IHistoryCommand
    {
        Task SetHistory(History history);
    }
}
