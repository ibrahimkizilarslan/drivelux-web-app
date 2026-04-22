using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.LocationCommands
{
    public class UpdateLocationCommands : IRequest
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}
