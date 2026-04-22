using MediatR;
using DriveLux.Application.Features.Mediator.Queries.BlogQueries;
using DriveLux.Application.Features.Mediator.Results.AuthorResults;
using DriveLux.Application.Features.Mediator.Results.BlogResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.BlogHandler
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResults>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResults> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            if (values == null)
            {
                throw new Exception($"Blog with ID {request.Id} not found.");
            }
            return new GetBlogByIdQueryResults
            {
                BlogID = values.BlogID,
                AuthorID = values.AuthorID,
                CoverImageUrl = values.CoverImageUrl,
                CreatedDate = values.CreatedDate,
                Description = values.Description,
                Title = values.Title
            };
        }
    }
}
