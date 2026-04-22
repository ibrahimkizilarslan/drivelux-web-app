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
    public class GetLocationCountQueryHandler : IRequestHandler<GetLocationCountQuery, GetLocationCountQueryResults>
    {
        private readonly IStatisticsRepository _repository;

        public GetLocationCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationCountQueryResults> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetLocationCount();
            return new GetLocationCountQueryResults
            {
                LocationCount = value,
            };
        }
    }
}