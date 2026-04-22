using MediatR;
using DriveLux.Application.Features.Mediator.Commands.PricingCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.PricingHandler
{
    public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommands>
    {

        private readonly IRepository<Pricing> _repository;

        public CreatePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatePricingCommands request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Pricing
            {
                Name = request.Name,
            });
        }
    }
}
