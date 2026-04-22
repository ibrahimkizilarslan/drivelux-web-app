using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class RemoveSocialMediaCommands : IRequest
    {
        public int Id { get; set; }

        public RemoveSocialMediaCommands(int id)
        {
            Id = id;
        }
    }
}
