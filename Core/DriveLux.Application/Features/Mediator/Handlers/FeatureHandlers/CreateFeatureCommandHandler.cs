using MediatR;
using DriveLux.Application.Features.Mediator.Commands.FeatureCommands;
using DriveLux.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand>
    {

        private readonly IRepository<Domain.Entities.Features> _repository;

        public CreateFeatureCommandHandler(IRepository<Domain.Entities.Features> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.Features
            {
               Name = request.Name,
            });
        }

    }
}
