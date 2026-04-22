using MediatR;
using DriveLux.Application.Features.Mediator.Commands.SocialMediaCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.SocialMediaHandler
{
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommands>
    {
        private readonly IRepository<SocialMedia> _repository;

        public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSocialMediaCommands request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.SocialMediaID);
            values.Icon = request.Icon;
            values.SocialMediaID = request.SocialMediaID;
            values.Name = request.Name;
            values.Url = request.Url;
            await _repository.UpdateAsync(values);
        }
    }
}
