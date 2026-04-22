using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.PricingCommands
{
    public class RemovePricingCommands : IRequest
    {
        public int Id { get; set; }

        public RemovePricingCommands(int id)
        {
            Id = id;
        }
    }
}
