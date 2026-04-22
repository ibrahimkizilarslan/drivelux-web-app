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
    public class GetBrandCountQueryHandler : IRequestHandler<GetBrandCountQuery, GetBrandCountQueryResults>
    {
        private readonly IStatisticsRepository _repository;

        public GetBrandCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandCountQueryResults> Handle(GetBrandCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBrandCount();
            return new GetBrandCountQueryResults
            {
                BrandCount = value,
            };
        }
    }
}
