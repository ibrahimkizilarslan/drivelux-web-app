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
    public class GetCarCountByKmSmallerThen1000QueryHandler : IRequestHandler<GetCarCountByKmSmallerThen1000Query, GetCarCountByKmSmallerThen1000QueryResults>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKmSmallerThen1000QueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmSmallerThen1000QueryResults> Handle(GetCarCountByKmSmallerThen1000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmSmallerThen1000();
            return new GetCarCountByKmSmallerThen1000QueryResults
            {

                CarCountByKmSmallerThen1000 = value,

            };
        }
    }
}
