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
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommands>
    {

        private readonly IRepository<SocialMedia> _repository;

        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSocialMediaCommands request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
               Name = request.Name,
               Url  = request.Url,
               Icon = request.Icon,
            });
        }
    }
}
