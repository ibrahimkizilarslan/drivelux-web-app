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
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResults>>
    {

        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResults>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBlogQueryResults
            {
                BlogID = x.BlogID,
                AuthorID = x.AuthorID,
                Title = x.Title,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
               
            }).ToList();
        }
    }
}
