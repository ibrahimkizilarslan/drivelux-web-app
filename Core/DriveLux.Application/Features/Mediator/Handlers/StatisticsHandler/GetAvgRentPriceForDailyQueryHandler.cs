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
    public class GetAvgRentPriceForDailyQueryHandler : IRequestHandler<GetAvgRentPriceForDailyQuery, GetAvgRentPriceForDailyQueryResults>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForDailyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForDailyQueryResults> Handle(GetAvgRentPriceForDailyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForDaily();
            return new GetAvgRentPriceForDailyQueryResults
            {
                AvgPriceForDaily = value,
            };
        }
    }
}
