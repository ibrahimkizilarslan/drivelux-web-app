using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class CreateTagCloudCommands : IRequest
    {
        public string Title { get; set; }
        public int BlogID { get; set; }

    }
}
