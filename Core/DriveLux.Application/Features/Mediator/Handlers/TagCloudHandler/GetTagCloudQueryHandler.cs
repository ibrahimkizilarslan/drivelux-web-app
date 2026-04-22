using MediatR;
using DriveLux.Application.Features.Mediator.Queries.ServiceQueries;
using DriveLux.Application.Features.Mediator.Queries.TagCloudQueries;
using DriveLux.Application.Features.Mediator.Results.ServiceResults;
using DriveLux.Application.Features.Mediator.Results.TagCloudResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.TagCloudHandler
{
    public class GetTagCloudQueryHandler : IRequestHandler<GetTagCloudQuery,List<GetTagCloudQueryResults>>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudQueryResults>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTagCloudQueryResults
            {
                TagCloudID = x.TagCloudID,
                Title = x.Title,
                BlogID = x.BlogID,
               
            }).ToList();
        }
    }
}
