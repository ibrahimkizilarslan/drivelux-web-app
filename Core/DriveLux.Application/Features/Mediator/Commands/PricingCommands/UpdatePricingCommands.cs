using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.PricingCommands
{
    public class UpdatePricingCommands : IRequest
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
    }
}
