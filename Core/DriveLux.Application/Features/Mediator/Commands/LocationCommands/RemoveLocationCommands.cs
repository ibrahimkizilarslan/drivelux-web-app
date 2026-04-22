using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.LocationCommands
{
    public class RemoveLocationCommands : IRequest
    {
        public int Id { get; set; }

        public RemoveLocationCommands(int id)
        {
            Id = id;
        }
    }
}
