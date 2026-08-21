using Application.Interfaces.Histories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mongo.Commands
{
    public class HistoryCommand : IHistoryCommand
    {
        public Task SetHistory(History history)
        {
            throw new NotImplementedException();
        }
    }
}
