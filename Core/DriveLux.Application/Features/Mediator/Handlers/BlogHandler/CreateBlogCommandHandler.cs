using MediatR;
using DriveLux.Application.Features.CQRS.Commands.AboutCommands;
using DriveLux.Application.Features.Mediator.Commands.BlogCommands;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.BlogHandler
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommands>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommands request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
                AuthorID = request.AuthorID,
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = request.CreatedDate,
                Title = request.Title,

            });
        }
    }
}
