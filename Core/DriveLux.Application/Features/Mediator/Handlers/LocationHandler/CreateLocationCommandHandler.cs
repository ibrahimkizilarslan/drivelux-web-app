using MediatR;
using DriveLux.Application.Features.Mediator.Commands.LocationCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.LocationHandler
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommands>
    {
        private readonly IRepository<Location> _repository;

        public CreateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateLocationCommands request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Location
            {
                Name = request.Name,
            });
        }
    }
}
