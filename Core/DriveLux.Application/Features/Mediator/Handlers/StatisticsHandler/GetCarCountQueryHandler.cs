using MediatR;
using DriveLux.Application.Features.Mediator.Queries.StatisticsQueries;
using DriveLux.Application.Features.Mediator.Results.FooterAddressResults;
using DriveLux.Application.Features.Mediator.Results.StatisticsResults;
using DriveLux.Application.Interfaces;
using DriveLux.Application.Interfaces.CarInterfaces;
using DriveLux.Application.Interfaces.StatisticsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.Mediator.Handlers.StatisticsHandler
{
    public class GetCarCountQueryHandler : IRequestHandler<GetCarCountQuery, GetCarCountQueryResults>
    {

        private readonly IStatisticsRepository _repository;

        public GetCarCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountQueryResults> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCount();
            return new GetCarCountQueryResults
            {
                CarCount = value,

            };
        }
    }
}
