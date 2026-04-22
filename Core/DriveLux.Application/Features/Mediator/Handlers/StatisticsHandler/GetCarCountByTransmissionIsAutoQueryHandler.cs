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
    public class GetCarCountByTransmissionIsAutoQueryHandler : IRequestHandler<GetCarCountByTransmissionIsAutoQuery, GetCarCountByTransmissionIsAutoQueryResults>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByTransmissionIsAutoQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByTransmissionIsAutoQueryResults> Handle(GetCarCountByTransmissionIsAutoQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByTransmissionIsAuto();
            return new GetCarCountByTransmissionIsAutoQueryResults
            {

               CarCountByTransmissionIsAuto = value

            };
        }
    }
}
