using MediatR;
using DriveLux.Application.Features.Mediator.Queries.TagCloudQueries;
using DriveLux.Application.Features.Mediator.Results.ServiceResults;
using DriveLux.Application.Features.Mediator.Results.TagCloudResults;
using DriveLux.Application.Interfaces.TagCloudInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.TagCloudHandler
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResults>>
    {

        private readonly ITagCloudRepository _repository;

        public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResults>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetTagCloudByBlogId(request.Id);
            return values.Select(x => new GetTagCloudByBlogIdQueryResults
            {
              TagCloudID = x.TagCloudID,
              Title = x.Title,
              BlogID = x.BlogID,
            }).ToList();
        }
    }
}
  

