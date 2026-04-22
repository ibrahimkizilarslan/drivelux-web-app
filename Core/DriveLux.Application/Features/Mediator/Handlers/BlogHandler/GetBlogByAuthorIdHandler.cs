using MediatR;
using DriveLux.Application.Features.Mediator.Queries.BlogQueries;
using DriveLux.Application.Features.Mediator.Results.BlogResults;
using DriveLux.Application.Interfaces.BlogInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.BlogHandler
{
    public class GetBlogByAuthorIdHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByAuthorIdHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBlogByAuthorId(request.Id);
            return values.Select(x => new GetBlogByAuthorIdQueryResult
            {
                BlogID = x.BlogID,
                AuthorID = x.AuthorID,
                AuthorName = x.Author.Name,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
            }).ToList();
        }
    }
}
