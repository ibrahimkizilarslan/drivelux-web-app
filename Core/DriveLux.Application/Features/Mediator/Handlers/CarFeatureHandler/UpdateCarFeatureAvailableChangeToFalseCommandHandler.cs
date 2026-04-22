using MediatR;
using DriveLux.Application.Features.Mediator.Commands.CarFeatureCommands;
using DriveLux.Application.Interfaces.CarFeatureInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.CarFeatureHandler
{
    public class UpdateCarFeatureAvailableChangeToFalseCommandHandler : IRequestHandler<UpdateCarFeatureAvailableChangeToFalseCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public UpdateCarFeatureAvailableChangeToFalseCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(UpdateCarFeatureAvailableChangeToFalseCommand request, CancellationToken cancellationToken)
        {
            _repository.ChangeCarFeatureAvailableToFalse(request.Id);
            return Task.CompletedTask;
        }
    }
}
