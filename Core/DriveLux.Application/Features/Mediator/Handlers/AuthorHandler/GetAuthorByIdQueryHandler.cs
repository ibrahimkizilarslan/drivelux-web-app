using MediatR;
using DriveLux.Application.Features.Mediator.Queries.AuthorQueries;
using DriveLux.Application.Features.Mediator.Results.AuthorResults;
using DriveLux.Application.Features.Mediator.Results.FeatureResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.AuthorHandler
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResults>
    {

        private readonly IRepository<Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResults> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResults
            {
                AuthorID = values.AuthorID,
                Name = values.Name,
                ImageUrl = values.ImageUrl,
                Description = values.Description
            };
        }
    }
}
