using MediatR;
using DriveLux.Application.Features.Mediator.Commands.AuthorCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.AuthorHandler
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommands>
    {
        private readonly IRepository<Author> _repository;

        public CreateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAuthorCommands request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Author
            {
                Name = request.Name,
                ImageUrl = request.ImageUrl,
                Description = request.Description
            });
        }
    }
}
