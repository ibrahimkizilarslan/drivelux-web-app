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
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResults>>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAuthorQueryResults>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResults
            {
                AuthorID = x.AuthorID,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Description = x.Description
            }).ToList();
        }
    }
 }
