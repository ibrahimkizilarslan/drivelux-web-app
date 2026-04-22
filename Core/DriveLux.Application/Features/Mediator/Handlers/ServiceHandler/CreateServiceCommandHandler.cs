using MediatR;
using DriveLux.Application.Features.Mediator.Commands.ServiceCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.ServiceHandler
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommands>
    {
        private readonly IRepository<Service> _repository;

        public CreateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommands request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service
            {
                Title = request.Title,
                Description = request.Description,
                IconUrl = request.IconUrl,
            });
        }
    }
}
