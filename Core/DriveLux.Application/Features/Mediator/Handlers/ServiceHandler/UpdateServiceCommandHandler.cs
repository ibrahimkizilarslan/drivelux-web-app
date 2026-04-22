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
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommands>
    {
        private readonly IRepository<Service> _repository;

        public UpdateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommands request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ServiceID);
            values.Title = request.Title;
            values.ServiceID = request.ServiceID;
            values.Description = request.Description;
            values.IconUrl = request.IconUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
