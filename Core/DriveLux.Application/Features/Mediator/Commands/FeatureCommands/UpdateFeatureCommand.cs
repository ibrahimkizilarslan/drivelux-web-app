using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand : IRequest
    {
        public int FeaturesID { get; set; }
        public string Name { get; set; }

    }
}
