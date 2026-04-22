using MediatR;
using DriveLux.Application.Features.Mediator.Queries.StatisticsQueries;
using DriveLux.Application.Features.Mediator.Results.StatisticsResults;
using DriveLux.Application.Interfaces.StatisticsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.StatisticsHandler
{
    public class GetAuthorCountQueryHandler : IRequestHandler<GetAuthorCountQuery, GetAuthorCountQueryResults>
    {
        private readonly IStatisticsRepository _repository;

        public GetAuthorCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorCountQueryResults> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAuthorCount();
            return new GetAuthorCountQueryResults
            {
                AuthorCount = value,
            };
        }
    }
}
