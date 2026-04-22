using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.ServiceCommands
{
    public class RemoveServiceCommands : IRequest
    {
        public int Id { get; set; }

        public RemoveServiceCommands(int id)
        {
            Id = id;
        }
    }
}
