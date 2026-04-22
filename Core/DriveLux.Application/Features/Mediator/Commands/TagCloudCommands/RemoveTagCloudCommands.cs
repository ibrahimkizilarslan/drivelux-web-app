using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class RemoveTagCloudCommands : IRequest
    {

        public int Id { get; set; }

        public RemoveTagCloudCommands(int id)
        {
            Id = id;
        }
    }
}
