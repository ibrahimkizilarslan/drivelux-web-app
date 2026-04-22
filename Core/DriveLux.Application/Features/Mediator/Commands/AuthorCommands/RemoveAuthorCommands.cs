using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.AuthorCommands
{
    public class RemoveAuthorCommands : IRequest
    {
        public int Id { get; set; }

        public RemoveAuthorCommands(int id)
        {
            Id = id;
        }
    }
}

