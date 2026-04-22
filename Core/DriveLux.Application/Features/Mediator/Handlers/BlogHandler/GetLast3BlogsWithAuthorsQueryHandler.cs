using MediatR;
using DriveLux.Application.Features.CQRS.Results.CarResults;
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
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResults>>
    {

        private readonly IBlogRepository _repository;

        public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResults>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResults
            {
                BlogID = x.BlogID,
                AuthorID = x.AuthorID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                AuthorName = x.Author.Name
            }).ToList();
        }
    }
}
